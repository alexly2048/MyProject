using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using System;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormEditCourse : FormDialog
    {
        public FormEditCourse(CourseService courseService)
        {
            this.courseService = courseService;
            InitializeComponent();
        }
        private readonly CourseService courseService;
        private bool isAdd = true;
        private Course course;
        private Action action;
        private void FormEditCourse_Load(object sender, EventArgs e)
        {
            InitialUI();
            SetValidation();
        }

        public override void Shower(Action action, bool isAdd, object content)
        {
            this.isAdd = isAdd;
            this.action = action;
            course = (Course)content;

            ShowDialog();
        }

        private void InitialUI()
        {
            editPanel1.labelControl1.Text = "科目编号";
            editPanel2.labelControl1.Text = "科目名称";

            if (!isAdd)
            {
                editPanel1.textEdit1.Text = course.COURSE_CODE;
                editPanel2.textEdit1.Text = course.COURSE_NAME;
            }
        }

        private void SetValidation()
        {
            SetIsNotBlankValidation(dxValidationProvider1, editPanel1.labelControl1, "请输入考试科目编号");
            SetIsNotBlankValidation(dxValidationProvider1, editPanel2.labelControl1, "请输入考试科目名称");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;

            course.COURSE_CODE = editPanel1.textEdit1.Text.Trim();
            course.COURSE_NAME = editPanel2.textEdit1.Text.Trim();

            if (isAdd)
            {
                courseService.AddCourse(course);
            }
            else
            {
                courseService.UpdateCourse(course);
            }
            ShowMsg("提交成功");
            action?.Invoke();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(ShowAffirm("是否退出编辑界面？") == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
