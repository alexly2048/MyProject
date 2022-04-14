using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using DevExpress.XtraBars;
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
    public partial class FormEditGrade : FormDialog
    {
        public FormEditGrade(GradeService gradeService)
        {
            InitializeComponent();
            this.gradeService = gradeService;
        }
        private readonly GradeService gradeService;
        private Action action;
        private Grade grade;
        private bool isAdd = true;

        public override void Shower(Action action, bool isAdd, object content)
        {
            this.action = action;
            this.isAdd = isAdd;
            grade = (Grade)content;

            ShowDialog();
        }
        private void FormEditGrade_Load(object sender, EventArgs e)
        {
            InitialUI();
            InitialData();
        }

        private void InitialUI()
        {
            editPanel1.labelControl1.Text = "年级编号";
            editPanel2.labelControl1.Text = "年级名称";
            SetIsNotBlankValidation(dxValidationProvider1, editPanel1.textEdit1, "请输入年级编号");
            SetIsNotBlankValidation(dxValidationProvider1, editPanel2.textEdit1, "请输入年级名称");
        }

        private void InitialData()
        {
            if (!isAdd)
            {
                editPanel1.textEdit1.Text = grade.GRADE_CODE;
                editPanel2.textEdit1.Text = grade.GRADE_NAME;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            grade.GRADE_CODE = editPanel1.textEdit1.Text.Trim();
            grade.GRADE_NAME = editPanel2.textEdit1.Text.Trim();
            if (isAdd)
            {
                gradeService.AddGrade(grade);
            }
            else
            {
                gradeService.UpdateGrade(grade);
            }
            ShowMsg("提交成功");
            action?.Invoke();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(ShowAffirm("是否退出当前界面？") == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
