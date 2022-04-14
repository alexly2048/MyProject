using FileManagement.Model;
using FileManagement.Service.DataService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagement.UI
{
    public partial class FrmEditProjectContract : FormDialog
    {
        public FrmEditProjectContract(ProjectContractService service)
        {
            InitializeComponent();
            contractService = service;
        }
        private bool addFlag = true;
        private ProjectContract contract = new ProjectContract();
        private readonly ProjectContractService contractService;
        private Action action;
        private void FrmEditProjectContract_Load(object sender, EventArgs e)
        {
            
        }
        
        /// <summary>
        /// 窗体显示方法
        /// </summary>
        /// <param name="isAdd"></param>
        /// <param name="content"></param>
        public override void Shower(Action action,bool isAdd=true, object content=null)
        {
            addFlag = isAdd;            
            if (!isAdd)
            { 
                contract = content as ProjectContract;
                textEdit1.Text = contract.PROJECT_NUMBER;
                textEdit2.Text = contract.PROJECT_NAME;
                textEdit3.Text = contract.CONTRACT_NO;
                textEdit4.Text = contract.CONTRACT_NAME;
                textEdit5.Text = contract.REMARK;
            }
            this.action = action;
            ShowDialog();
        }
        /// <summary>
        /// 用户提交数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            dxValidationProvider1.Validate();

            contract.PROJECT_NUMBER = textEdit1.Text.Trim();
            contract.PROJECT_NAME = textEdit2.Text.Trim();
            contract.CONTRACT_NO = textEdit3.Text.Trim();
            contract.CONTRACT_NAME = textEdit4.Text.Trim();
            contract.REMARK = textEdit5.Text.Trim();
            if (addFlag)
            {
                contractService.AddProjectContract(contract);
            }
            else
            {
                contractService.UpdateProjectContract(contract);
            }
            
            ShowMsg("已成功提交数据");
            action?.Invoke();
            Close();
        }
    }
}
