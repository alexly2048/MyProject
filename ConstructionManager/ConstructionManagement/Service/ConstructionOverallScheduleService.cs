using System;
using System.Collections.Generic;
using System.Linq;
using ConstructionManagement.Model;

namespace ConstructionManagement.Service
{
    public class ConstructionOverallScheduleService : Connection
    {
        public ConstructionOverallScheduleService() : base()
        {
            quantityService = new ConstructionQuantityService();
            nodeService = new ConstructionNodeService();
        }
        private ConstructionQuantityService quantityService;
        private ConstructionNodeService nodeService;
        public IList<ConstructionOverallSchedule> GetOverallSchedules()
        {
            try
            {
                /*
                string query = "SELECT ID,ProjectCode,ProjectName,ProjectSchedule FROM ConstructionOverallSchedule";
                var result = Query<ConstructionOverallSchedule>(query);
                */
                var nodes = nodeService.GetConstructionNodes();
                var result = new List<ConstructionOverallSchedule>();
                foreach (var n in nodes)
                {
                    var overall = new ConstructionOverallSchedule
                    {
                        ID = n.ID,
                        ParentId = n.ID,
                        ProjectCode = n.ConstructionNo,
                        ProjectName = n.Name
                    };
                    result.Add(overall);
                }
                foreach (var r in result)
                {
                    var quantity = quantityService.GetConstructionQuantity(r.ID);
                    if (quantity == null || quantity.Count == 0)
                    {
                        r.ProjectSchedule = "0%";
                        continue;
                    }

                    var allDesign = quantity.Sum(x => (Convert.ToDecimal(x.DesignNum) + Convert.ToDecimal(x.ModifyNum)));
                    var allWorkDone = quantity.Sum(x => Convert.ToDecimal(string.IsNullOrEmpty(x.AllOfProcess) ? "0" : x.AllOfProcess));
                    var percent = 0m;
                    if(allDesign == 0)
                    {
                        percent = 0;
                    }
                    else
                    {
                        percent = allWorkDone / allDesign;
                    }
                     

                    r.ProjectSchedule = Math.Round((percent * 100), 2).ToString() + "%";
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Absolete

        /*

            public void AddSchedule(ConstructionOverallSchedule schedule)
            {
                try
                {
                    var insert = "INSERT INTO ConstructionOverallSchedule (ProjectCode,ProjectName) VALUES (@ProjectCode,@ProjectName)";
                    var r = Execute(insert, schedule);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public  void UpdateSchedule(ConstructionOverallSchedule schedule)
            {
                try
                {
                    var update = "UPDATE ConstructionOverallSchedule SET ProjectCode=@ProjectCode,ProjectName=@ProjectName WHERE ID=@ID";
                    var r = Execute(update, schedule);
                }
                catch (Exception)
                {

                }
            }

            public void DeleteSchedule(ConstructionOverallSchedule schedule)
            {
                try
                {
                    var delete = "DELETE FROM ConstructionOverallSchedule WHERE ID=@ID";
                    var r = Execute(delete, new { ID = schedule.ID });
                }
                catch (Exception)
                {
                    throw;
                }
            }

        */
        #endregion
    }
}
