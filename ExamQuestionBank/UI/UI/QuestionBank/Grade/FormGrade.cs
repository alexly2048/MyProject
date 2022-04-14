using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using DevExpress.XtraBars;
using IOCService.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormGrade : FormBase
    {
        public FormGrade(GradeService gradeService)
        {
            InitializeComponent();
            this.gradeService = gradeService;
        }
        private GradeService gradeService;

        private void FormGrade_Load(object sender, EventArgs e)
        {
            InitialUI();
            SetAuthories();
            QueryData();
        }

        private void SetAuthories()
        {
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("C101")))
            {
                buttonPanel1.btnQuery.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("C102")))
            {
                buttonPanel1.btnAdd.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("C103")))
            {
                buttonPanel1.btnUpdate.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("C104")))
            {
                buttonPanel1.btnDelete.Enabled = false;
            }
        }
        private void InitialUI()
        {
            gridView1.CustomDrawRowIndicator += GridView_CustomDrawRowIndicator_Event;
            gridView1.TopRowChanged += TopRowChanged_Event;
            buttonPanel1.btnAdd.Click += BtnAdd_Click;
            buttonPanel1.btnDelete.Click += BtnDelete_Click;
            buttonPanel1.btnQuery.Click += BtnQuery_Click;
            buttonPanel1.btnUpdate.Click += BtnUpdate_Click;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if (rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as Grade;
                var frm = AppContainer.Resolve<FormEditGrade>();
                frm.Shower(QueryData, false, data);
            }
            else
            {
                ShowMsg("请选择要更新的数据");
            }
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        private void QueryData()
        {
            var key = buttonPanel1.textKeyword.Text.Trim();
            var r = gradeService.GetGrades(key);
            if (r.Any())
            {
                bindingSource1.DataSource = r;
            }
            else
            {
                bindingSource1.DataSource = null;
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if (rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as Grade;
                if(ShowAffirm("是否删除选择的数据？") == DialogResult.OK)
                {
                    gradeService.DeleteGrade(data);
                    ShowMsg("删除成功");
                    QueryData();
                }
            }
            else
            {
                ShowMsg("请选择要删除的数据");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frm = AppContainer.Resolve<FormEditGrade>();
            var c = new Grade();
            frm.Shower(QueryData, true, c);
        }
    }
}
