using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using IOCService.Service;
using System;
using System.Linq;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormCourse : FormBase
    {
        public FormCourse(CourseService courseService)
        {
            InitializeComponent();
            this.courseService = courseService;
        }

        private readonly CourseService courseService;

        private void FormCourse_Load(object sender, EventArgs e)
        {
            InitialUI();
            SetAuthories();
        }

        private void SetAuthories()
        {
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("B101")))
            {
                buttonPanel1.btnQuery.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("B102")))
            {
                buttonPanel1.btnAdd.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("B103")))
            {
                buttonPanel1.btnUpdate.Enabled = false;
            }
            if (!AppHost.CurrentUserAuthorities.Any(x => x.ITEM_ID.Equals("B104")))
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

            QueryData();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var rows = gridView1.GetSelectedRows();
            if (rows.Length > 0) 
            {
                var data = gridView1.GetRow(rows[0]) as Course;
                var frm = AppContainer.Resolve<FormEditCourse>();
                frm.Shower(QueryData,false,data);
            }
            else
            {
                ShowMsg("请选择要更新的数据行");
            }
        }

        private void QueryData()
        {
            var key = buttonPanel1.textKeyword.Text.Trim();
            var r = courseService.GetCourses(key);
            if (r.Any())
            {
                bindingSource1.DataSource = r;
            }
            else
            {
                bindingSource1.DataSource = null;
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
                var data = gridView1.GetRow(rows[0]) as Course;
                if(ShowAffirm("是否删除选择的数据？") == System.Windows.Forms.DialogResult.OK)
                {
                    courseService.DeleteCourse(data);
                    ShowMsg("删除成功");
                    QueryData();
                }
            }
            else
            {
                ShowMsg("请选择要删除的数据行");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frm = AppContainer.Resolve<FormEditCourse>();
            var c = new Course();
            frm.Shower(QueryData, true, c);
        }
    }
}
