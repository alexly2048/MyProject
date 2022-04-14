using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.UI
{
    public partial class FrmConstructionMethod : example
    {
        public FrmConstructionMethod()
        {
            InitializeComponent();
            planService = new ConstructionPlanService();
        }

        ConstructionPlanService planService;
        public delegate void RefreshCallBack();
        public event RefreshCallBack CallBack;
        public ConstructionPlanModel Plan { get; set; }
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConstructionMethod_Load(object sender, EventArgs e)
        {
            try
            {
                rtbMethod.Text = Plan.ConstructionMethod;
            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }

        /// <summary>
        /// 提交修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var method = rtbMethod.Text.Trim();
                Plan.ConstructionMethod = method;
                planService.UpdateConstructionMethod(Plan);
                ShowMsg("修改成功");
                CallBack?.Invoke();
                Close();

            }catch(Exception ex)
            {
                ShowMsg(ex.Message);
            }
        }
    }
}
