using CommonService;
using CustomerUI.Model;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.Model.QuestionBankModel.View;
using Dapper;
using Dapper.Contrib.Extensions;
using DBHelper;
using DevExpress.Office.Drawing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CustomerUI.DBService.QuestionService
{
    public class UserExamService
    {
        public UserExamService(IDatabaseService service,
            QuestionImageService imageService)
        {
            this.service = service;
            this.imageService = imageService;
        }
        private readonly IDatabaseService service;
        private readonly QuestionImageService imageService;

        public IEnumerable<DisplayUserExam> GetUserExams(string key)
        {
            var r = service.GetAll<DisplayUserExam>();
            if (!string.IsNullOrWhiteSpace(key))
                r = r.Where(x => x.USER_ID.Contains(key) ||
                        x.GRADE_CODE.Contains(key) ||
                        x.COURSE_CODE.Contains(key) ||
                        x.USER_NAME.Contains(key) ||
                        x.GRADE_NAME.Contains(key) ||
                        x.COURSE_NAME.Contains(key));
            return r;
        }

        public IEnumerable<DisplayUserExam> GetUserExamsByUserId(string userId, string key)
        {
            var s = "SELECT * FROM V_USER_EXAM WHERE USER_ID=@USER_ID";
            var r = service.Query<DisplayUserExam>(s, new { USER_ID = userId });
            if (!string.IsNullOrEmpty(key))
            {
                r = r.Where(x => x.USER_ID.Contains(key) ||
                        x.GRADE_CODE.Contains(key) ||
                        x.COURSE_CODE.Contains(key) ||
                        x.USER_NAME.Contains(key) ||
                        x.GRADE_NAME.Contains(key) ||
                        x.COURSE_NAME.Contains(key));
            }
            return r;
        }

        public long AddUserExam(UserExam userExam)
        {
            var r = service.Insert(userExam);
            return r;
        }

        public bool UpdateUserExam(UserExam exam)
        {
            var r = service.Update(exam);
            return r;
        }

        public bool DeleteUserExam(UserExam exam)
        {
            var r = service.Delete(exam);
            return r;
        }

        public int DeleteUserExamById(DisplayUserExam exam)
        {
            var s = "DELETE FROM T_USER_EXAM WHERE ID=@ID";
            var r = service.Execute(s, new { ID = exam.ID });
            return r;
        }

        public bool UpdateUserExamStatus(string userId, string userExamGuid)
        {
            var s = "UPDATE T_USER_EXAM SET IS_COMPLETE=@IS_COMPLETE,COMPLETE_DATE=@COMPLETE_DATE WHERE USER_ID=@USER_ID AND USER_EXAM_GUID=@USER_EXAM_GUID";
            var r = service.Execute(s, new { IS_COMPLETE = true, COMPLETE_DATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), USER_ID = userId, USER_EXAM_GUID = userExamGuid });
            return r == 1;
        }

        public long SaveUserExamResult(DisplayUserExam display,ExamView view)
        {
            var update = "UPDATE T_USER_EXAM SET IS_COMPLETE=@IS_COMPLETE,COMPLETE_DATE=@COMPLETE_DATE WHERE USER_ID=@USER_ID AND USER_EXAM_GUID=@USER_EXAM_GUID";

            var userResult = new UserExamResult();
            userResult.USER_ID = display.USER_ID;
            userResult.USER_EXAM_GUID = display.USER_EXAM_GUID;
            userResult.SCORE = (decimal)view.TotalScore;
            userResult.EXAM_CONTENT = view.ToJson();
            
            using(var c = new SqlConnection(service.ConnectString))
            {
                c.Open();
                var transaction = c.BeginTransaction();
                try
                {
                    c.Execute(update, 
                        new { IS_COMPLETE = true, COMPLETE_DATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), USER_ID = display.USER_ID, USER_EXAM_GUID = display.USER_EXAM_GUID },
                        transaction);
                    var r = c.Insert(userResult, transaction);

                    AddOrUpdateScore(display,view,c,transaction); // 保存分数
                    SaveQuestionHistory(display, view, c, transaction);
                    transaction.Commit();
                    return r;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
                finally
                {
                    c.Close();
                }
            }



        }

        public ExamView GetUserExamView(DisplayUserExam display)
        {
            var s = "SELECT EXAM_CONTENT FROM T_USER_EXAM_RESULT WHERE USER_ID=@USER_ID AND USER_EXAM_GUID=@USER_EXAM_GUID";
            var r = service.QueryFirstOrDefault<string>(s, display);
            var view = r.ToObject<ExamView>();
            var images = imageService.GetQuestionImages();
            foreach(var v in view.GenerateExamViews)
            {
                var i = images.Where(x => x.QUESTION_GUID.Equals(v.Question.QUESTION_GUID)).ToList();
                v.Images = i;
            }
            return view;
        }

        public bool UpdateUserExamView(DisplayUserExam display, ExamView view)
        {
            if(CheckUserExamView(display))
            {
                var u = "UPDATE T_USER_EXAM_RESULT SET EXAM_CONTENT=@EXAM_CONTENT WHERE USER_ID=@USER_ID AND USER_EXAM_GUID=@USER_EXAM_GUID";
                using (var c = new SqlConnection(service.ConnectString))
                {
                    c.Open();
                    var transaction = c.BeginTransaction();
                    try
                    {
                        var rr = c.Execute(u,
                        new { EXAM_CONTENT = view.ToJson(), USER_ID = display.USER_ID, USER_EXAM_GUID = display.USER_EXAM_GUID },
                        transaction);
                        AddOrUpdateScore(display,view,c,transaction); // 保存分数
                        SaveQuestionHistory(display, view, c, transaction);
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                    
                }
                
                
                return true;
            }
            else
            {
                throw new Exception($"用户考试{display.USER_EXAM_GUID}不存在");
            }
        }


        private void AddOrUpdateScore(DisplayUserExam display,ExamView view,SqlConnection c,IDbTransaction transaction)
        {
            var s = "SELECT ID FROM T_USER_EXAM_SCORE WHERE USER_ID=@USER_ID AND USER_EXAM_GUID=@USER_EXAM_GUID";
            var r = service.QueryFirstOrDefault<int?>(s, new { USER_ID = display.USER_ID, USER_EXAM_GUID = display.USER_EXAM_GUID });

            var userscore = StatisticScore(display,view);
            if(r.HasValue)
            {
                userscore.ID = (int)r;
                c.Update(userscore,transaction);
            }
            else
            {
                c.Insert(userscore,transaction);
            }
        }

        private UserExamScore StatisticScore(DisplayUserExam display,ExamView view)
        {
            var score = new UserExamScore();
            var groupBySubjectType = view.GenerateExamViews.GroupBy(x => x.Subject.SUBJECT_TYPE);
            foreach(var g in groupBySubjectType)
            {
                switch (g.Key)
                {
                    case SubjectTypeEnum.Eassay:
                        score.EASSAY_SCORE = g.ToList().Sum(x => x.UserScore);
                        break;
                    case SubjectTypeEnum.FillBlank:
                        score.FILL_BANK_SCORE = g.ToList().Sum(x => x.UserScore);
                        break;
                    case SubjectTypeEnum.Judge:
                        score.JUDGE_SCORE = g.ToList().Sum(x => x.UserScore);
                        break;
                    case SubjectTypeEnum.MultiSelect:
                        score.MULTI_SELECT_SCORE = g.ToList().Sum(x => x.UserScore);
                        break;
                    case SubjectTypeEnum.Reader:
                        score.READER_SCORE = g.ToList().Sum(x => x.UserScore);
                        break;
                    case SubjectTypeEnum.Select:
                        score.SINGLE_SELECT_SCORE = g.ToList().Sum(x => x.UserScore);
                        break;
                    case SubjectTypeEnum.Writing:
                        score.WRITING_SCORE = g.ToList().Sum(x => x.UserScore);
                        break;
                    default:
                        break;
                }
            }

            score.USER_ID = display.USER_ID;
            score.USER_NAME = display.USER_NAME;
            score.USER_EXAM_GUID = display.USER_EXAM_GUID;
            score.TOTAL_SCORE = score.SINGLE_SELECT_SCORE 
                + score.MULTI_SELECT_SCORE 
                + score.FILL_BANK_SCORE
                + score.JUDGE_SCORE
                + score.READER_SCORE
                + score.EASSAY_SCORE
                + score.WRITING_SCORE;
            return score;
        }

        internal bool CheckUserExamView(DisplayUserExam display)
        {
            var s = "SELECT 1 FROM T_USER_EXAM_RESULT WHERE USER_ID=@USER_ID AND USER_EXAM_GUID=@USER_EXAM_GUID";
            var r = service.QueryFirstOrDefault<int?>(s, new { USER_ID = display.USER_ID, USER_EXAM_GUID = display.USER_EXAM_GUID });
            if (r.HasValue && r == 1)
                return true;
            return false;
        }

        /// <summary>
        /// 保存问题
        /// </summary>
        /// <param name="user"></param>
        /// <param name="view"></param>
        /// <param name="c"></param>
        /// <param name="transaction"></param>
        internal void SaveQuestionHistory(DisplayUserExam user, ExamView view,SqlConnection c, IDbTransaction transaction)
        {
            var u = user;
            var ve = view;
            var s = "DELETE FROM T_USER_EXAM_HISTORY WHERE USER_ID=@USER_ID AND USER_EXAM_GUID=@USER_EXAM_GUID";
            var r = c.Execute(s, u, transaction);
            
            foreach(var v in view.GenerateExamViews)
            {
                var h = new UserExamHistory
                {
                    USER_ID =u.USER_ID,
                    USER_NAME = u.USER_NAME,
                    USER_EXAM_GUID = u.USER_EXAM_GUID,
                    QUESTION_GUID = v.Question.QUESTION_GUID,
                    QUESTION_TYPE = v.Question.QUESTION_TYPE,
                    QUESTION_ORDER = v.Order,
                    QUESTION_CONTENT = v.Question.QUESTION_CONTENT,
                    ANSWER = v.Answer?.ANSWER_CONTENT?.ToString()??string.Empty,
                    SCORE = v.Question.SCORE,
                    USER_SCORE = v.UserScore,
                    USER_ANSWER = v.UserAnswer,
                };
                
                if(h.QUESTION_TYPE == QuestionTypeEnum.Select || h.QUESTION_TYPE == QuestionTypeEnum.Judge)
                {
                    if(h.USER_SCORE != 0 && h.USER_SCORE == h.SCORE)
                    {
                        h.ANSWER_STATUS = AnswerStatusEnum.Correct;
                    }
                    else
                    {
                        h.ANSWER_STATUS = AnswerStatusEnum.Error;
                    }
                }
                else
                {
                    h.ANSWER_STATUS = AnswerStatusEnum.Undefined;
                }

                c.Insert(h, transaction);

            }
        }

        public IEnumerable<UserExamHistory> GetUserExamHistories(DisplayUserExam display)
        {
            var r = service.GetAll<UserExamHistory>();
            r = r.Where(x => x.USER_EXAM_GUID.Equals(display.USER_EXAM_GUID));
            return r;
        }

        public IEnumerable<UserExamScore> GetUserExamScores(DisplayUserExam display)
        {
            var r = service.GetAll<UserExamScore>();
            r = r.Where(x => x.USER_ID.Equals(display.USER_ID) && x.USER_EXAM_GUID.Equals(display.USER_EXAM_GUID));
            return r;
        }
    }
}
