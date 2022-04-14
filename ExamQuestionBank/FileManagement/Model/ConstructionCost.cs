namespace FileManagement.Model
{
    public class ConstructionCost : BaseEntity
    {

        /// <summary>
        /// 工程编号
        /// </summary>
        public string PROJECT_NUMBER { get; set; }
        /// <summary>
        /// 工程名称
        /// </summary>
        public string PROJECT_NAME { get; set; }
        /// <summary>
        /// 总造价
        /// </summary>
        public decimal TOTAL_COST { get; set; } = 0;
        /// <summary>
        /// 设计费
        /// </summary>
        public decimal DESIGN_COST { get; set; } = 0;
        /// <summary>
        /// 监理费
        /// </summary>
        public decimal SUPERVISOR_COST { get; set; } = 0;
        /// <summary>
        /// 试验费及检验费
        /// </summary>
        public decimal EXPERIMENT_COST { get; set; } = 0;
        /// <summary>
        /// 安装工程
        /// </summary>
        public decimal INSTALLATION_COST { get; set; } = 0;
        /// <summary>
        /// 建筑工程
        /// </summary>
        public decimal CONSTRUCTION_COST { get; set; } = 0;
        /// <summary>
        /// 安全文明施工费
        /// </summary>
        public decimal SAFE_CIVILIZED_COST { get; set; } = 0;
        /// <summary>
        /// 其他
        /// </summary>
        public decimal OTHER_COST { get; set; } = 0;
        /// <summary>
        /// 预算施工费
        /// </summary>
        public decimal BUDGET_CONSTRUCTION_COST { get; set; } = 0;
        /// <summary>
        /// 分包费
        /// </summary>
        public decimal SUBCONTRACT_COST { get; set; } = 0;
        /// <summary>
        /// 送审价
        /// </summary>
        public decimal REVIEW_COST { get; set; } = 0;
        /// <summary>
        /// 审定价
        /// </summary>
        public decimal APPROVED_COST { get; set; } = 0;
        /// <summary>
        /// 税率
        /// </summary>
        public string RATE { get; set; }
        /// <summary>
        /// 管理费点
        /// </summary>
        public string MANAGEMENT_COST_RATE { get; set; }
        /// <summary>
        /// 管理费
        /// </summary>
        public decimal MANAGEMENT_COST { get; set; } = 0;
        /// <summary>
        /// 劳务
        /// </summary>
        public decimal LABOR_COST { get; set; } = 0;
        /// <summary>
        /// 审定试验费及检验费
        /// </summary>
        public decimal INSPECTION_COST { get; set; } = 0;
        /// <summary>
        /// 材料费用
        /// </summary>
        public decimal MATERIAL_COST { get; set; } = 0;
        /// <summary>
        /// 材料税
        /// </summary>
        public decimal MATERIAL_TAX { get; set; } = 0;
        /// <summary>
        /// 日常开支费用
        /// </summary>
        public decimal GENERAL_COST { get; set; } = 0;
        /// <summary>
        /// 利润
        /// </summary>
        public decimal PROFIT { get; set; } = 0;
    }
}
