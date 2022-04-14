using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using IOCService.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormSelectExam : FormBase
    {
        public FormSelectExam(UserExamService userExamService)
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

        private  void InitialUI()
        {
            gridView1.CustomDrawRowIndicator += GridView_CustomDrawRowIndicator_Event;
            gridView1.TopRowChanged += TopRowChanged_Event;
            btnPanel.btnQuery.Click += BtnQuery_Click;
            btnPanel.btnAdd.Text = "开始考试";
            btnPanel.btnAdd.Click += BtnAdd_Click;
            btnPanel.btnAdd.ImageOptions.Image = ImageResource.begin_green_16;
            btnPanel.btnDelete.Visible = false;
            btnPanel.btnUpdate.Text = "查看试卷";
            btnPanel.btnUpdate.Click += BtnUpdate_Click;
        }

        private void SetAuthories()
        {
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("F101")))
            {
                btnPanel.btnQuery.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("F103")))
            {
                btnPanel.btnAdd.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("F102")))
            {
                btnPanel.btnUpdate.Enabled = false;
            }
        }

        /// <summary>
        /// 用户考试完成，用于查看试卷
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if (rows.Length > 0)
            {
                var data = gridView1.GetRow(rows[0]) as DisplayUserExam;
                var frm = AppContainer.Resolve<FormUserExamHistory>();
                frm.Shower(QueryData, true, data);
            }
            else
            {
                ShowMsg("请选择用查看的数据");
            }
        }

        /// <summary>
        /// 复用 btnAdd按钮，作为开始考试按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if (rows.Length> 0)
            {
                var data = gridView1.GetRow(rows[0]) as DisplayUserExam;
                var frm = AppContainer.Resolve<FormExam>();
                frm.Shower(QueryData, true, data);
            }
        }

        private void QueryData()
        {
            var key = btnPanel.textKeyword.Text.Trim();
            if(AppHost.CurrentUser == null)
            {
                ShowMsg("缺少用户信息");
                return;
            }
            var r = userExamService.GetUserExamsByUserId(AppHost.CurrentUser.UserId,key);
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

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }
        /// <summary>
        /// 显示考试完成状态
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
        }
    }
}
