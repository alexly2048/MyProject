using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionManagement.Model;

namespace ConstructionManagement.Service
{
    public class AcceptanceService:Connection
    {
        public AcceptanceService() : base()
        {
            imageService = new AcceptanceImageService();
        }
        AcceptanceImageService imageService;
        public IList<Acceptance> GetAcceptances(ProjectKindEnum projectKind)
        {
            try
            {
                var query = "SELECT ID,ProjectNo,ProjectName,ProjectKind,ItemName,ItemFeature,ItemUnit,Remark1,Remark2,Remark3,Description,Question,Rectify  FROM Acceptance WHERE ProjectKind=@ProjectKind";
                var result = Query<Acceptance>(query, new { ProjectKind = projectKind });
                return result;
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DelAcceptance(Acceptance acceptance)
        {
            try
            {
                if (IfAcceptanceExists(acceptance))
                {
                    var query = "DELETE FROM Acceptance WHERE ID=@ID";
                    var result = Execute(query, new { ID = acceptance.ID });
                    imageService.DeletaImagesByParentId(acceptance.ID);
                }
                else
                {
                    throw new Exception("数据不存在");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool IfAcceptanceExists(Acceptance acceptance)
        {
            try
            {
                var query = "SELECT 1 FROM Acceptance WHERE ID=@ID";
                var result = Query<int>(query, new { ID = acceptance.ID }).FirstOrDefault();
                if (result == 1)
                    return true;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AddAcceptance(Acceptance acceptance)
        {
            try
            {
                var query = "INSERT INTO Acceptance (ProjectNo,ProjectName,ProjectKind,ItemName,ItemFeature,ItemUnit,Remark1,Remark2,Remark3,Description,Question,Rectify) VALUES (@ProjectNo,@ProjectName,@ProjectKind,@ItemName,@ItemFeature,@ItemUnit,@Remark1,@Remark2,@Remark3,@Description,@Question,@Rectify)";
                return Execute(query, acceptance);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int UpdateAcceptance(Acceptance acceptance)
        {
            try
            {
                var query = "UPDATE Acceptance SET ProjectNo=@ProjectNo,ProjectName=@ProjectName,ProjectKind=@ProjectKind,ItemName=@ItemName,ItemFeature=@ItemFeature,ItemUnit=@ItemUnit,Remark1=@Remark1,Remark2=@Remark2,Remark3=@Remark3,Description=@Description,Question=@Question,Rectify=@Rectify WHERE ID=@ID";
                return Execute(query, acceptance);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
