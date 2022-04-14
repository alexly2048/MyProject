using CustomerUI.Model.QuestionBankModel;
using Dapper;
using DBHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CustomerUI.DBService.QuestionService
{
    public class QuestionImageService
    {
        public QuestionImageService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;

        internal void AddImage(QuestionImage img, SqlConnection c, IDbTransaction transaction)
        {
            service.Insert(img, c, transaction);
        }

        internal void UpdateImage(QuestionImage img, SqlConnection c, IDbTransaction transaction)
        {
            service.Update(img, c, transaction);
        }

        internal void DeleteImage(QuestionImage img, SqlConnection c, IDbTransaction transaction)
        {
            service.Delete(img, c, transaction);
        }

        internal IEnumerable<QuestionImage> GetQuestionImages(string guid)
        {
            var s = "SELECT ID,QUESTION_GUID,IMAGE_CONTENT FROM T_QUESTION_IMAGE WHERE QUESTION_GUID=@QUESTION_GUID";
            var r = service.Query<QuestionImage>(s, new { QUESTION_GUID = guid });
            return r;
        }

        internal bool DeleteQuestinImage(QuestionImage image)
        {
            if (CheckImage((int)image.ID))
            {
                service.Delete(image);
            }
            return true;
        }

        internal bool CheckImage(int id)
        {
            var s = "SELECT 1 FROM T_QUESTION_IMAGE WHERE ID=@ID";
            var r = service.QueryFirstOrDefault<int?>(s, new { ID = id });
            if(r.HasValue && r == 1)
            {
                return true;
            }
            return false;
        }

        internal void UpdateImage(QuestionImage image)
        {
            service.Update(image);
        }

        internal int AddImage(QuestionImage image)
        {
            var s = "INSERT INTO T_QUESTION_IMAGE (QUESTION_GUID,IMAGE_CONTENT) VALUES (@QUESTION_GUID,@IMAGE_CONTENT);SELECT CAST(SCOPE_IDENTITY() AS int)";
            var r = service.QueryFirstOrDefault<int>(s, image);
            return r;
        }

        internal void DeleteImageByGuid(string guid, SqlConnection c, SqlTransaction transaction)
        {
            var s = "DELETE FROM T_QUESTION_IMAGE WHERE QUESTION_GUID=@QUESTION_GUID";
            c.Execute(s, new { QUESTION_GUID = guid }, transaction);
        }

        internal IEnumerable<QuestionImage> GetQuestionImages()
        {
            var r = service.GetAll<QuestionImage>();
            return r;
        }
    }
}
