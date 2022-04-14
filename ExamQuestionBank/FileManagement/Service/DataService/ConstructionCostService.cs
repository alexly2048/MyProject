using FileManagement.Model;
using System.Collections.Generic;

namespace FileManagement.Service.DataService
{
    public class ConstructionCostService
    {
        public ConstructionCostService(IDatabaseService service,CurrentExpenseService currentService)
        {
            this.service = service;
            this.currentService = currentService;
        }
        private readonly IDatabaseService service;
        private CurrentExpenseService currentService;

        public int AddConstructionCost(ConstructionCost cost)
        {
            var select = "INSERT INTO [dbo].[CONSTRUCTION_COST]([PARENT_ID],[PROJECT_NUMBER],[PROJECT_NAME],[TOTAL_COST],[DESIGN_COST],[SUPERVISOR_COST],[EXPERIMENT_COST],[INSTALLATION_COST],[CONSTRUCTION_COST],[SAFE_CIVILIZED_COST],[OTHER_COST],[BUDGET_CONSTRUCTION_COST],[SUBCONTRACT_COST],[REVIEW_COST],[APPROVED_COST],[RATE],[MANAGEMENT_COST_RATE],[MANAGEMENT_COST],[LABOR_COST],[INSPECTION_COST],[MATERIAL_COST],[MATERIAL_TAX],[GENERAL_COST],[PROFIT])     VALUES(@PARENT_ID,@PROJECT_NUMBER,@PROJECT_NAME,@TOTAL_COST,@DESIGN_COST,@SUPERVISOR_COST,@EXPERIMENT_COST,@INSTALLATION_COST,@CONSTRUCTION_COST,@SAFE_CIVILIZED_COST,@OTHER_COST,@BUDGET_CONSTRUCTION_COST,@SUBCONTRACT_COST,@REVIEW_COST,@APPROVED_COST,@RATE,@MANAGEMENT_COST_RATE,@MANAGEMENT_COST,@LABOR_COST,@INSPECTION_COST,@MATERIAL_COST,@MATERIAL_TAX,@GENERAL_COST,@PROFIT)";
            var r = service.Execute(select,cost);
            return r;
        }

        public int UpdateConstructionCost(ConstructionCost cost)
        {
            var update = "UPDATE [dbo].[CONSTRUCTION_COST] SET [PARENT_ID]=@PARENT_ID,[PROJECT_NUMBER]=@PROJECT_NUMBER,[PROJECT_NAME]=@PROJECT_NAME,[TOTAL_COST]=@TOTAL_COST,[DESIGN_COST]=@DESIGN_COST,[SUPERVISOR_COST]=@SUPERVISOR_COST,[EXPERIMENT_COST]=@EXPERIMENT_COST,[INSTALLATION_COST]=@INSTALLATION_COST,[CONSTRUCTION_COST]=@CONSTRUCTION_COST,[SAFE_CIVILIZED_COST]=@SAFE_CIVILIZED_COST,[OTHER_COST]=@OTHER_COST,[BUDGET_CONSTRUCTION_COST]=@BUDGET_CONSTRUCTION_COST,[SUBCONTRACT_COST]=@SUBCONTRACT_COST,[REVIEW_COST]=@REVIEW_COST,[APPROVED_COST]=@APPROVED_COST,[RATE]=@RATE,[MANAGEMENT_COST_RATE]=@MANAGEMENT_COST_RATE,[MANAGEMENT_COST]=@MANAGEMENT_COST,[LABOR_COST]=@LABOR_COST,[INSPECTION_COST]=@INSPECTION_COST,[MATERIAL_COST]=@MATERIAL_COST,[MATERIAL_TAX]=@MATERIAL_TAX,[GENERAL_COST]=@GENERAL_COST,[PROFIT]=@PROFIT WHERE ID=@ID";
            var r = service.Execute(update, cost);
            return r;
        }

        public IEnumerable<ConstructionCost> GetConstructionCosts(string keyword)
        {
            var select = "SELECT [ID],[PARENT_ID],[PROJECT_NUMBER],[PROJECT_NAME],[TOTAL_COST],[DESIGN_COST],[SUPERVISOR_COST],[EXPERIMENT_COST],[INSTALLATION_COST],[CONSTRUCTION_COST],[SAFE_CIVILIZED_COST],[OTHER_COST],[BUDGET_CONSTRUCTION_COST],[SUBCONTRACT_COST],[REVIEW_COST],[APPROVED_COST],[RATE],[MANAGEMENT_COST_RATE],[MANAGEMENT_COST],[LABOR_COST],[INSPECTION_COST],[MATERIAL_COST],[MATERIAL_TAX],[GENERAL_COST],[PROFIT]  FROM [dbo].[CONSTRUCTION_COST]";
            var r = service.Query<ConstructionCost>(select);
            foreach(var d in r)
            {

                d.GENERAL_COST = currentService.GetCurrentExpenseSumByParentId(d.ID);
            }
            return r;
        }

        public int DeleteConstructionCost(ConstructionCost cost)
        {
            var delete = "DELETE FROM CONSTRUCTION_COST WHERE ID=@ID";
            var r = service.Execute(delete, cost);
            return r;
        }

        public int DeleteConstructionCostByParentId(int parentId)
        {
            var delete = "DELETE FROM CONSTRUCTION_COST WHERE PARENT_ID=@PARENT_ID";
            var r = service.Execute(delete, new { PARENT_ID = parentId });
            return r;
        }
    }
}
