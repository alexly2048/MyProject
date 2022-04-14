using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using IOCService.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormExamBank : FormBase
    {
        public FormExamBank(ExamBankService examService)
        {
            InitializeComponent();
            this.examService = examService;
        }
        private readonly ExamBankService examService;

        private void FormExamBank_Load(object sender, EventArgs e)
        {
            InitialUI();
            InitialData();
            SetAuthories();
        }

        private void SetAuthories()
        {
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("D101")))
            {
                btnPanel.btnQuery.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("D102")))
            {
                btnPanel.btnAdd.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("D103")))
            {
                btnPanel.btnUpdate.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("D104")))
            {
                btnPanel.btnDelete.Enabled = false;
            }
        }

        private void InitialUI()
        {
            gridView1.CustomDrawRowIndicator += GridView_CustomDrawRowIndicator_Event;
            gridView1.TopRowChanged += TopRowChanged_Event;

            btnPanel.btnAdd.Click += BtnAdd_Click;
            btnPanel.btnDelete.Click += BtnDelete_Click;
            btnPanel.btnQuery.Click += BtnQuery_Click;
            btnPanel.btnUpdate.Click += BtnUpdate_Click;
        }

        private void InitialData()
        {
            QueryData();
        }

        private void QueryData()
        {
            var key = btnPanel.textKeyword.Text.Trim();
            var r = examService.GetExamBanks(key);
            if (r.Any())
            {
                bankSource.DataSource = r;
            }
            else
            {
                bankSource.DataSource = null;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if(rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as DisplayExamBank;
                var frm = AppContainer.Resolve<FormEditExamBank>();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if (rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as DisplayExamBank;
                if(ShowAffirm("是否删除选择的试卷？") == DialogResult.OK)
                {
                    examService.DeleteExamBankByGuid(data.EXAM_GUID);
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
            var frm = AppContainer.Resolve<FormEditExamBank>();
            frm.Shower(QueryData, true, null);
        }
    }
}
