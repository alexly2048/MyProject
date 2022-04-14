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
    public class ConstructionPlanService:Connection
    {
        public ConstructionPlanService() : base()
        {

        }
        public IList<ConstructionPlanModel> QueryByParentId(int parentId)
        {
            try
            {
                string select = "SELECT ID,ParentId,ConstructionNo,PlanDate,ConstructionItem,ConstructionPart,CivilWorks,NumOfPerson,Leader,ConstructionMethod,Remark FROM ConstructionPlan WHERE ParentId=@ParentId";
                var result = Query<ConstructionPlanModel>(select, new { ParentId = parentId });
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateConstructionPlan(ConstructionPlanModel plan)
        {
            try
            {
                string update = "UPDATE ConstructionPlan SET ConstructionNo=@ConstructionNo,PlanDate=@PlanDate,ConstructionItem=@ConstructionItem,ConstructionPart=@ConstructionPart,CivilWorks=@CivilWorks,NumOfPerson=@NumOfPerson,Leader=@Leader,ConstructionMethod=@ConstructionMethod,Remark=@Remark WHERE ID=@ID";
                Execute(update, plan);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateConstructionMethod(ConstructionPlanModel plan)
        {
            try
            {
                string updateMethod = "UPDATE ConstructionPlan SET ConstructionMethod=@ConstructionMethod WHERE ID=@ID";
                Execute(updateMethod, new { ID = plan.ID, ConstructionMethod = plan.ConstructionMethod });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddConstructionPlan(ConstructionPlanModel plan)
        {
            try
            {
                string insert = "INSERT INTO ConstructionPlan (ParentId,ConstructionNo,PlanDate,ConstructionItem,ConstructionPart,CivilWorks,NumOfPerson,Leader,ConstructionMethod,Remark) VALUES (@ParentId,@ConstructionNo,@PlanDate,@ConstructionItem,@ConstructionPart,@CivilWorks,@NumOfPerson,@Leader,@ConstructionMethod,@Remark)";
                Execute(insert, plan);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeletePlan(ConstructionPlanModel plan)
        {
            try
            {
                var query = "DELETE FROM ConstructionPlan WHERE ID=@ID";
                Execute(query, new { ID = plan.ID });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeletePlanByParentId(int parentId)
        {
            try
            {
                var del = "DELETE FROM ConstructionPlan WHERE ParentId=@ParentId";
                Execute(del, new { ParentId = parentId });
            }catch(Exception ex)
            {
                throw;
            }
        }
    }
}
