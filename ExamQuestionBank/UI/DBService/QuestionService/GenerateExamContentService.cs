using CustomerUI.Model;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.Model.QuestionBankModel.View;
using DevExpress.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.DBService.QuestionService
{
    public class GenerateExamContentService
    {
        public GenerateExamContentService( ExamBankService bankService,
            QuestionService questionService,
            SubjectService subjectService,
            AnswerService answerService,
            QuestionImageService questionImageService,
            QuestionItemService questionItemService,
            SubjectDescriptionService subjectDescriptionService)
        {
            this.bankService = bankService;
            this.questionService = questionService;
            this.subjectService = subjectService;
            this.questionImageService = questionImageService;
            this.questionItemService = questionItemService;
            this.answerService = answerService;
            this.subjectDescriptionService = subjectDescriptionService;
        }
        private readonly ExamBankService bankService;
        private readonly QuestionService questionService;
        private readonly SubjectService subjectService;
        private readonly AnswerService answerService;
        private readonly QuestionImageService questionImageService;
        private readonly QuestionItemService questionItemService;
        private readonly SubjectDescriptionService subjectDescriptionService;
        public ExamView GenerateExamContentByUserId(DisplayUserExam displayexam)
        {
            var tmp = displayexam;
            // First, get exams
            var exams =  bankService.GetExamBanksByExamGuid(tmp.EXAM_GUID);
            if (!exams.Any()) throw new Exception($"未查询到考试{tmp.EXAM_GUID}配置，请联系管理人员");
            // get subject info
            var subjects = subjectService.GetSubjectByGradeAndDifficulty(displayexam.GRADE_CODE, displayexam.COURSE_CODE) ;

            // 获取题型设置
            var selectSetting = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.Select);
            var multiSelectSetting = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.MultiSelect);
            var judgeSetting = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.Judge);
            var fillSetting = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.FillBlank);
            var readSetting = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.Reader);
            var essaySetting = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.Eassay);
            var writeSetting = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.Writing);

            var selectSubjects = subjects.Where(x => x.SUBJECT_TYPE == SubjectTypeEnum.Select);
            var multiSelectSubjects = subjects.Where(x => x.SUBJECT_TYPE == SubjectTypeEnum.MultiSelect);
            var judgeSubjects = subjects.Where(x => x.SUBJECT_TYPE == SubjectTypeEnum.Judge);
            var fillSubjects = subjects.Where(x => x.SUBJECT_TYPE == SubjectTypeEnum.FillBlank);
            var readSubjects = subjects.Where(x => x.SUBJECT_TYPE == SubjectTypeEnum.Reader);
            var essaySubjects = subjects.Where(x => x.SUBJECT_TYPE == SubjectTypeEnum.Eassay);
            var writeSubjects = subjects.Where(x => x.SUBJECT_TYPE == SubjectTypeEnum.Writing);

            var selectResult = new List<Subject>();
            var multiSelectResult = new List<Subject>();
            var judgeResult = new List<Subject>();
            var fillResult = new List<Subject>();
            var readResult = new List<Subject>();
            var essayResult = new List<Subject>();
            var writeResult = new List<Subject>();
            string msg = string.Empty;
            if(selectSetting != null)
            {
                if(!GenerateSubjects(selectSetting,selectSubjects,out selectResult,out msg))
                {
                    throw new Exception("生成选择题失败\r\n"+msg);
                }
            }
            if(multiSelectSetting != null)
            {
                if(!GenerateSubjects(multiSelectSetting,multiSelectSubjects,out multiSelectResult,out msg))
                {
                    throw new Exception("生成多选题失败\r\n" + msg);
                }
            }
            if(judgeSetting != null)
            {
                if(!GenerateSubjects(judgeSetting,judgeSubjects,out judgeResult,out msg))
                {
                    throw new Exception("生成判断题失败\r\n" + msg);
                }
            }
            if(fillSetting != null)
            {
                if(!GenerateSubjects(fillSetting,fillSubjects,out fillResult,out msg))
                {
                    throw new Exception("生成填空题失败\r\n" + msg);
                }
            }
            if(readSetting != null)
            {
                if(!GenerateSubjects(readSetting,readSubjects,out readResult,out msg))
                {
                    throw new Exception("生成阅读理解题失败\r\n" + msg);
                }
            }
            if(essaySetting != null)
            {
                if(!GenerateSubjects(essaySetting,essaySubjects,out essayResult,out msg))
                {
                    throw new Exception("生成问答题失败\r\n" + msg);
                }
            }
            if(writeSetting != null)
            {
                if(!GenerateSubjects(writeSetting,writeSubjects,out writeResult,out msg))
                {
                    throw new Exception("生成写作题失败" + msg);
                }
            }
            
            // Second, get all Questions
            var questions = questionService.GetQuestions(null);
            var answers = answerService.GetAnswers();
            var questionItems = questionItemService.GetQuestionItems();
            var questionImages = questionImageService.GetQuestionImages();
            var subjectDescriptions = subjectDescriptionService.GetSubjectDescriptions();
            var questionIndex = 0;
            var examView = new ExamView();
            examView.User = AppHost.CurrentUser;
            var examBank = new ExamBank
            {
                COURSE_CODE = displayexam.COURSE_CODE,
                GRADE_CODE = displayexam.GRADE_CODE,
                EXAM_GUID = displayexam.EXAM_GUID
            };
            examView.ExamBank = examBank;
            foreach(var r in selectResult)
            {
                var qs = questions.Where(x => x.SUBJECT_GUID.Equals(r.SUBJECT_GUID));
                foreach(var q in qs)
                {
                    var g = new GenerateExamView();
                    g.Order = questionIndex;
                    g.Subject = r;
                    var description = subjectDescriptions.FirstOrDefault(x => x.SUBJECT_GUID.Equals(q.SUBJECT_GUID));
                    g.Description = description;
                    g.Question = q;
                    var an = answers.FirstOrDefault(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Answer = an;
                    var items = questionItems.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Items.AddRange(items.ToArray());
                    var images = questionImages.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Images.AddRange(images);
                    examView.GenerateExamViews.Add(g);
                    questionIndex++;
                }               
            }
            foreach(var r in multiSelectResult)
            {
                var qs = questions.Where(x => x.SUBJECT_GUID.Equals(r.SUBJECT_GUID));
                foreach(var q in qs)
                {
                    var g = new GenerateExamView();
                    g.Order = questionIndex;
                    g.Subject = r;
                    var description = subjectDescriptions.FirstOrDefault(x => x.SUBJECT_GUID.Equals(q.SUBJECT_GUID));
                    g.Description = description;
                    g.Question = q;
                    var an = answers.FirstOrDefault(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Answer = an;
                    var items = questionItems.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Items.AddRange(items.ToArray());
                    var images = questionImages.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Images.AddRange(images);
                    examView.GenerateExamViews.Add(g);
                    questionIndex++;
                }
            }
            foreach (var r in judgeResult)
            {
                var qs = questions.Where(x => x.SUBJECT_GUID.Equals(r.SUBJECT_GUID));
                foreach (var q in qs)
                {
                    var g = new GenerateExamView();
                    g.Order = questionIndex;
                    g.Subject = r;
                    var description = subjectDescriptions.FirstOrDefault(x => x.SUBJECT_GUID.Equals(q.SUBJECT_GUID));
                    g.Description = description;
                    g.Question = q;
                    var an = answers.FirstOrDefault(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Answer = an;
                    var items = questionItems.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Items.AddRange(items.ToArray());
                    var images = questionImages.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Images.AddRange(images);
                    examView.GenerateExamViews.Add(g);
                    questionIndex++;
                }
            }
            foreach (var r in fillResult)
            {
                var qs = questions.Where(x => x.SUBJECT_GUID.Equals(r.SUBJECT_GUID));
                foreach (var q in qs)
                {
                    var g = new GenerateExamView();
                    g.Order = questionIndex;
                    g.Subject = r;
                    var description = subjectDescriptions.FirstOrDefault(x => x.SUBJECT_GUID.Equals(q.SUBJECT_GUID));
                    g.Description = description;
                    g.Question = q;
                    var an = answers.FirstOrDefault(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Answer = an;
                    var items = questionItems.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Items.AddRange(items.ToArray());
                    var images = questionImages.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Images.AddRange(images);
                    examView.GenerateExamViews.Add(g);
                    questionIndex++;
                }
            }
            foreach (var r in readResult)
            {
                var qs = questions.Where(x => x.SUBJECT_GUID.Equals(r.SUBJECT_GUID));
                foreach (var q in qs)
                {
                    var g = new GenerateExamView();
                    g.Order = questionIndex;
                    g.Subject = r;
                    var description = subjectDescriptions.FirstOrDefault(x => x.SUBJECT_GUID.Equals(q.SUBJECT_GUID));
                    g.Description = description;
                    g.Question = q;
                    var an = answers.FirstOrDefault(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Answer = an;
                    var items = questionItems.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Items.AddRange(items.ToArray());
                    var images = questionImages.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Images.AddRange(images);
                    examView.GenerateExamViews.Add(g);
                    questionIndex++;
                }
            }
            foreach (var r in essayResult)
            {
                var qs = questions.Where(x => x.SUBJECT_GUID.Equals(r.SUBJECT_GUID));
                foreach (var q in qs)
                {
                    var g = new GenerateExamView();
                    g.Order = questionIndex;
                    g.Subject = r;
                    var description = subjectDescriptions.FirstOrDefault(x => x.SUBJECT_GUID.Equals(q.SUBJECT_GUID));
                    g.Description = description;
                    g.Question = q;
                    var an = answers.FirstOrDefault(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Answer = an;
                    var items = questionItems.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Items.AddRange(items.ToArray());
                    var images = questionImages.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Images.AddRange(images);
                    examView.GenerateExamViews.Add(g);
                    questionIndex++;
                }
            }
            foreach (var r in writeResult)
            {
                var qs = questions.Where(x => x.SUBJECT_GUID.Equals(r.SUBJECT_GUID));
                foreach (var q in qs)
                {
                    var g = new GenerateExamView();
                    g.Order = questionIndex;
                    g.Subject = r;
                    var description = subjectDescriptions.FirstOrDefault(x => x.SUBJECT_GUID.Equals(q.SUBJECT_GUID));
                    g.Description = description;
                    g.Question = q;
                    var an = answers.FirstOrDefault(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Answer = an;
                    var items = questionItems.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Items.AddRange(items.ToArray());
                    var images = questionImages.Where(x => x.QUESTION_GUID.Equals(q.QUESTION_GUID));
                    g.Images.AddRange(images);
                    examView.GenerateExamViews.Add(g);
                    questionIndex++;
                }
            }

            return examView;

        }

        /// <summary>
        /// 根据考试配置信息，获取Subjects信息
        /// </summary>
        /// <param name="examSetting"></param>
        /// <param name="subjects"></param>
        /// <param name="result"></param>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        public bool GenerateSubjects(ExamBank examSetting,IEnumerable<Subject> subjects, out List<Subject> result, out string errMsg)
        {
            var inner = subjects;
            var setting = examSetting;
            result = new List<Subject>();
            if(examSetting == null)
            {
                result = null;
                errMsg = "考试配置参数为空";
                return false;
            }
            var count = setting.VERY_EASY + setting.EASY + setting.COMMON + setting.DIFFICULTY + setting.VERY_DIFFICULTY;
            if (count > subjects.Count())
            {
                result = null;
                errMsg = $"生成试卷失败\r\n题型：{examSetting.SUBJECT_TYPE.ToString()}试卷设置题目数量多于题库中题目数量";
                return false;
            }

            var veryEasySubjects = subjects.Where(x => x.DIFFICULTY_LEVEL == DifficultyLevelEnum.VeryEasy).ToList();
            var easySubjects = subjects.Where(x => x.DIFFICULTY_LEVEL == DifficultyLevelEnum.Easy).ToList();
            var commonSubjects = subjects.Where(x => x.DIFFICULTY_LEVEL == DifficultyLevelEnum.Common).ToList();
            var difficultySubjects = subjects.Where(x => x.DIFFICULTY_LEVEL == DifficultyLevelEnum.Difficulty).ToList();
            var veryDifficultySubjects = subjects.Where(x => x.DIFFICULTY_LEVEL == DifficultyLevelEnum.VeryDifficulty).ToList();

            var veryEasyCount = veryEasySubjects.Count();
            var easyCount = easySubjects.Count();
            var commonCount = commonSubjects.Count();
            var difficultyCount = difficultySubjects.Count();
            var veryDifficultyCount = veryDifficultySubjects.Count();

            if (setting.VERY_EASY > veryEasyCount ||
                setting.EASY > easyCount ||
                setting.COMMON > commonCount ||
                setting.DIFFICULTY > difficultyCount ||
                setting.VERY_DIFFICULTY > veryDifficultyCount)
            {
                result = null;
                errMsg = $"生成试卷失败\r\n题型：{examSetting.SUBJECT_TYPE.ToString()}试卷设置题目数量多于题库中题目数量";
                return false;
            }

            var random = new Random();
            var veryEasyIndex = new List<int>();
            var easyIndex = new List<int>();
            var commonIndex = new List<int>();
            var difficultyIndex = new List<int>();
            var veryDifficultyIndex = new List<int>();

            while(veryEasyIndex.Count() != setting.VERY_EASY)
            {
                veryEasyIndex.Add(random.Next() % veryEasyCount);
                veryEasyIndex = veryEasyIndex.Distinct().ToList();
            }
            while(easyIndex.Count() != setting.EASY)
            {
                easyIndex.Add(random.Next() % easyCount);
                easyIndex = easyIndex.Distinct().ToList();
            }
            while(commonIndex.Count() != setting.COMMON)
            {
                commonIndex.Add(random.Next() % commonCount);
                commonIndex = commonIndex.Distinct().ToList();
            }
            while(difficultyIndex.Count() != setting.DIFFICULTY)
            {
                difficultyIndex.Add(random.Next() % difficultyCount);
                difficultyIndex = difficultyIndex.Distinct().ToList();
            }
            while(veryDifficultyIndex.Count() != veryDifficultyCount)
            {
                veryDifficultyIndex.Add(random.Next() % veryDifficultyCount);
                veryDifficultyIndex = veryDifficultyIndex.Distinct().ToList();
            }

            foreach(var i in veryEasyIndex)
            {
                result.Add(veryEasySubjects[i]);
            }
            foreach(var i in easyIndex)
            {
                result.Add(easySubjects[i]);
            }
            foreach(var i in commonIndex)
            {
                result.Add(commonSubjects[i]);
            }
            foreach(var i in difficultyIndex)
            {
                result.Add(difficultySubjects[i]);
            }
            foreach(var i in veryDifficultyIndex)
            {
                result.Add(veryDifficultySubjects[i]);
            }
            errMsg = "Success";
            return true;
                
        }

    }
}
