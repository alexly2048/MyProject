using CustomerUI.Model.QuestionBankModel;
using DBHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.DBService.QuestionService
{
    public class QuestionViewService
    {
        public QuestionViewService(IDatabaseService service,
            AnswerService answerService,
            QuestionService questionService,
            QuestionImageService imageService,
            QuestionItemService itemService,
            SubjectService subjectService,
            SubjectDescriptionService descriptionService)
        {
            this.service = service;
            this.answerService = answerService;
            this.questionService = questionService;
            this.imageService = imageService;
            this.itemService = itemService;
            this.subjectService = subjectService;
            this.descriptionService = descriptionService;
        }
        private readonly IDatabaseService service;
        private readonly AnswerService answerService;
        private readonly QuestionService questionService;
        private readonly QuestionImageService imageService;
        private readonly QuestionItemService itemService;
        private readonly SubjectService subjectService;
        private readonly SubjectDescriptionService descriptionService;

        internal void AddQuestion(QuestionViewModel questionView)
        {
            if (questionView == null) throw new ArgumentNullException(nameof(questionView));

            var view = questionView;
            using(var c = new SqlConnection(service.ConnectString))
            {
                c.Open();
                var transaction = c.BeginTransaction();
                try
                {
                    subjectService.AddSubject(view.Subject,c,transaction);
                    if(view.QuestionDescription != null && 
                        !string.IsNullOrEmpty(view.QuestionDescription.DESCRIPTION))
                    {
                        descriptionService.AddQuestionDescription(view.QuestionDescription, c, transaction);
                    }

                    foreach(var q in view.Questions)
                    {
                        questionService.AddQuestion(q, c, transaction);
                    }

                    foreach(var i in view.QuestionItems)
                    {
                        itemService.AddQuestionItem(i, c, transaction);
                    }

                    if(view.Answers != null && view.Answers.Count > 0)
                    {
                        foreach(var a in view.Answers)
                        {
                            answerService.AddAnswer(a, c, transaction);
                        }
                    }

                    foreach(var img in view.QuestionImages)
                    {
                        imageService.AddImage(img, c, transaction);
                    }
                    transaction.Commit();
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

        internal void UpdateQuestion(EditQuestionModel question)
        {
            using(var c = new SqlConnection(service.ConnectString))
            {
                c.Open();
                var transaction = c.BeginTransaction();

                try {

                    subjectService.UpdateSubject(question.Subject, c, transaction);

                questionService.UpdateQuestion(question.Question, c, transaction);

                itemService.DeleteQuestionItemByGuid(question.Question.QUESTION_GUID, c, transaction);
                foreach(var i in question.Items)
                {
                    itemService.AddQuestionItem(i, c, transaction);
                }

                answerService.DeleteAnswerByGuid(question.Question.QUESTION_GUID, c, transaction);
                answerService.AddAnswer(question.Answer, c, transaction);

                transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
                finally { c.Close(); }
            }
        }

        internal void DeleteQuestion(DisplayQuestionView display)
        {
            using (var c = new SqlConnection(service.ConnectString))
            {
                c.Open();
                var transaction = c.BeginTransaction();
                try
                {
                    if(display.SUBJECT_TYPE != SubjectTypeEnum.Reader)
                    {
                        questionService.DeleteQuestionByGuid(display.QUESTION_GUID, c, transaction);
                        itemService.DeleteQuestionItemByGuid(display.QUESTION_GUID, c, transaction);
                        answerService.DeleteAnswerByGuid(display.QUESTION_GUID, c, transaction);
                        imageService.DeleteImageByGuid(display.QUESTION_GUID, c, transaction);
                        subjectService.DeleteSubjectByGuid(display.SUBJECT_GUID, c, transaction);
                    }
                    else
                    {
                        var questionGuids = questionService.GetQuestionGuidsBySubjectGuid(display.SUBJECT_GUID);
                        subjectService.DeleteSubjectByGuid(display.SUBJECT_GUID, c, transaction);
                        foreach(var q in questionGuids)
                        {
                            questionService.DeleteQuestionByGuid(display.QUESTION_GUID, c, transaction);
                            itemService.DeleteQuestionItemByGuid(display.QUESTION_GUID, c, transaction);
                            answerService.DeleteAnswerByGuid(display.QUESTION_GUID, c, transaction);
                            imageService.DeleteImageByGuid(display.QUESTION_GUID, c, transaction);
                        }
                    }                   
                    transaction.Commit();
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
    }
}
