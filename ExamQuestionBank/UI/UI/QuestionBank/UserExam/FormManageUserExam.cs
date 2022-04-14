using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using IOCService.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormManageUserExam : FormBase
    {
        public FormManageUserExam(UserExamService userExamService)
        {
            InitializeComponent();
            this.userExamService = userExamService;
        }
        private readonly UserExamService userExamService;

        private void FormUserExam_Load(object sender, EventArgs e)
        {
            InitialUI();
            QueryData();
            SetAuthories();
        }

        private void SetAuthories()
        {
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("E101")))
            {
                btnPanel.btnQuery.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("E102")))
            {
                btnPanel.btnAdd.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("E103")))
            {
                btnPanel.btnUpdate.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("E104")))
            {
                btnPanel.btnDelete.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("E105")))
            {
                btnCheckUserExam.Enabled = false;
            }
        }

        private  void InitialUI()
        {
            gridView1.CustomDrawRowIndicator += GridView_CustomDrawRowIndicator_Event;
            gridView1.TopRowChanged += TopRowChanged_Event;

            btnPanel.btnAdd.Click += BtnAdd_Click;
            btnPanel.btnDelete.Click += BtnDelete_Click;
            btnPanel.btnQuery.Click += BtnQuery_Click;
            btnPanel.btnUpdate.Click += BtnUpdate_Click;
        }

        private void QueryData()
        {
            var key = btnPanel.textKeyword.Text.Trim();
            var r = userExamService.GetUserExams(key);
            if (r.Any())
            {
                userExamSource.DataSource = r;
            }
            else
            {
                ShowMsg("未查询到数据");
                userExamSource.DataSource = null;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if (rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as DisplayUserExam;
                var frm = AppContainer.Resolve<FormEditUserExam>();
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
                var data = gridView1.GetRow(rows[0]) as DisplayUserExam;
                if(ShowAffirm("是否删除选择的数据？") == DialogResult.OK)
                {
                    userExamService.DeleteUserExamById(data);
                    ShowMsg("删除成功");
                    QueryData();
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frm = AppContainer.Resolve<FormEditUserExam>();
            frm.Shower(QueryData, true, null);
        }
        /// <summary>
        /// 格式化考试状态显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName.Equals("IS_COMPLETE"))
            {
                var v = (bool)e.Value;
                if (v)
                {
                    e.DisplayText = "已完成";
                }
                else
                {
                    e.DisplayText = "未完成";
                }
            }
            if (e.Column.FieldName.Equals("IS_ENABLE"))
            {
                var r = (bool)e.Value;
                if (r)
                {
                    e.DisplayText = "启用";
                }
                else
                {
                    e.DisplayText = "未启用";
                }
            }
        }

        /// <summary>
        /// 打开审阅试卷窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckUserExam_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if(rows.Length > 0)
            {
                var view = gridView1.GetRow(rows[0]) as DisplayUserExam;
                var frm = AppContainer.Resolve<FormCheckExam>();
                frm.Shower(QueryData, false, view);
            }
            else
            {
                ShowMsg("请选择要查看的试卷");
            }
        }
    }
}
