using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormEditExamBank : FormDialog
    {
        public FormEditExamBank(GradeService gradeService,
            CourseService courseService,
            ExamBankService bankService)
        {
            InitializeComponent();
            this.gradeService = gradeService;
            this.courseService = courseService;
            this.bankService = bankService;
        }
        private readonly GradeService gradeService;
        private readonly CourseService courseService;
        private readonly ExamBankService bankService;
        private DisplayExamBank examBank;
        private Action action;
        private bool isAdd = true;
        private ExamBank select;
        private ExamBank multiSelect;
        private ExamBank fill;
        private ExamBank judge;
        private ExamBank eassy;
        private ExamBank writing;
        private ExamBank reading;
        private void FrmEditExamBank_Load(object sender, EventArgs e)
        {
            InitialUI();
            InitialData();
        }

        private void InitialUI()
        {
            var grades = gradeService.GetGrades(null).Select(x => new { 年级编号 = x.GRADE_CODE, 年级名称 = x.GRADE_NAME }).ToList();
            var courses = courseService.GetCourses(null).Select(x => new { 课程编号 = x.COURSE_CODE, 课程名称 = x.COURSE_NAME }).ToList();

            lookupGrade.Properties.DataSource = grades;
            lookupGrade.Properties.DisplayMember = "年级名称";
            lookupGrade.Properties.ValueMember = "年级编号";
            lookupGrade.Properties.NullText = string.Empty;
            lookupGrade.Properties.NullValuePrompt = "请选择年级";
            lookupGrade.ItemIndex = -1;

            lookupCourse.Properties.DataSource = courses;
            lookupCourse.Properties.DisplayMember = "课程名称";
            lookupCourse.Properties.ValueMember = "课程编号";
            lookupCourse.Properties.NullText = string.Empty;
            lookupCourse.Properties.NullValuePrompt = "请选择课程";
            lookupCourse.ItemIndex = -1;

            SetIsNotBlankValidation(dxValidationProvider1, lookupGrade, "请选择年级");
            SetIsNotBlankValidation(dxValidationProvider1, lookupCourse, "请选择课程");

            SetNumberValidation(dxValidationProvider1, t11, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t12, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t13, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t14, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t15, "请输入数字");

            SetNumberValidation(dxValidationProvider1, t21, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t22, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t23, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t24, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t25, "请输入数字");

            SetNumberValidation(dxValidationProvider1, t31, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t32, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t33, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t34, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t35, "请输入数字");

            SetNumberValidation(dxValidationProvider1, t41, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t42, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t43, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t44, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t45, "请输入数字");

            SetNumberValidation(dxValidationProvider1, t51, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t52, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t53, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t54, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t55, "请输入数字");

            SetNumberValidation(dxValidationProvider1, t61, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t62, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t63, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t64, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t65, "请输入数字");

            SetNumberValidation(dxValidationProvider1, t71, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t72, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t73, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t74, "请输入数字");
            SetNumberValidation(dxValidationProvider1, t75, "请输入数字");

            t11.Properties.Click += MouseClick_Event;
        }

        private void MouseClick_Event(object sender, EventArgs e)
        {
            var control = sender as TextEdit;
            control.SelectAll();
        }

        private void InitialData()
        {
            if (!isAdd)
            {
                var exams = bankService.GetExamBanksByExamGuid(examBank.EXAM_GUID);
                
                select = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.Select);
                multiSelect = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.MultiSelect);
                fill = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.FillBlank);
                judge = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.Judge);
                reading = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.Reader);
                eassy = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.Eassay);
                writing = exams.FirstOrDefault(x => x.SUBJECT_TYPE == SubjectTypeEnum.Writing);

                t11.Text = select.VERY_EASY.ToString();
                t12.Text = select.EASY.ToString();
                t13.Text = select.COMMON.ToString();
                t14.Text = select.DIFFICULTY.ToString();
                t15.Text = select.VERY_DIFFICULTY.ToString();

                t21.Text = fill.VERY_EASY.ToString();
                t22.Text = fill.EASY.ToString();
                t23.Text = fill.COMMON.ToString();
                t24.Text = fill.DIFFICULTY.ToString();
                t25.Text = fill.VERY_DIFFICULTY.ToString();

                t31.Text = judge.VERY_EASY.ToString();
                t32.Text = judge.EASY.ToString();
                t33.Text = judge.COMMON.ToString();
                t34.Text = judge.DIFFICULTY.ToString();
                t35.Text = judge.VERY_DIFFICULTY.ToString();

                t41.Text = eassy.VERY_EASY.ToString();
                t42.Text = eassy.EASY.ToString();
                t43.Text = eassy.COMMON.ToString();
                t44.Text = eassy.DIFFICULTY.ToString();
                t45.Text = eassy.VERY_DIFFICULTY.ToString();

                t51.Text = multiSelect.VERY_EASY.ToString();
                t52.Text = multiSelect.EASY.ToString();
                t53.Text = multiSelect.COMMON.ToString();
                t54.Text = multiSelect.DIFFICULTY.ToString();
                t55.Text = multiSelect.VERY_DIFFICULTY.ToString();

                t61.Text = reading.VERY_EASY.ToString();
                t62.Text = reading.EASY.ToString();
                t63.Text = reading.COMMON.ToString();
                t64.Text = reading.DIFFICULTY.ToString();
                t65.Text = reading.VERY_DIFFICULTY.ToString();

                t71.Text = writing.VERY_EASY.ToString();
                t72.Text = writing.EASY.ToString();
                t73.Text = writing.COMMON.ToString();
                t74.Text = writing.DIFFICULTY.ToString();
                t75.Text = writing.VERY_DIFFICULTY.ToString();

                lookupGrade.Text = examBank.GRADE_NAME;
                lookupGrade.EditValue = examBank.GRADE_CODE;
                lookupCourse.Text = examBank.COURSE_NAME;
                lookupCourse.EditValue = examBank.COURSE_CODE;

                checkEnable.Checked = select.IS_ENABLE;
            }
            else
            {
                select = new ExamBank();
                multiSelect = new ExamBank();
                fill = new ExamBank();
                judge = new ExamBank();
                reading = new ExamBank();
                eassy = new ExamBank();
                writing = new ExamBank();
            }
        }

        public override void Shower(Action action, bool isAdd, object content)
        {
            this.action = action;
            this.isAdd = isAdd;
            examBank = (DisplayExamBank)content;

            ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            var gradeCode = lookupGrade.EditValue?.ToString();
            var courseCode = lookupCourse.EditValue?.ToString();
            var enable = checkEnable.Checked;
            select.GRADE_CODE = gradeCode;
            select.COURSE_CODE = courseCode;
            select.SUBJECT_TYPE = SubjectTypeEnum.Select;
            select.IS_ENABLE = enable;

            fill.GRADE_CODE = gradeCode;
            fill.COURSE_CODE = courseCode;
            fill.SUBJECT_TYPE = SubjectTypeEnum.FillBlank;
            fill.IS_ENABLE = enable;

            judge.GRADE_CODE = gradeCode;
            judge.COURSE_CODE = courseCode;
            judge.SUBJECT_TYPE = SubjectTypeEnum.Judge;
            judge.IS_ENABLE = enable;

            eassy.GRADE_CODE = gradeCode;
            eassy.COURSE_CODE = courseCode;
            eassy.SUBJECT_TYPE = SubjectTypeEnum.Eassay;
            eassy.IS_ENABLE = enable;

            multiSelect.GRADE_CODE = gradeCode;
            multiSelect.COURSE_CODE = courseCode;
            multiSelect.SUBJECT_TYPE = SubjectTypeEnum.MultiSelect;
            multiSelect.IS_ENABLE = enable;

            reading.GRADE_CODE = gradeCode;
            reading.COURSE_CODE = courseCode;
            reading.SUBJECT_TYPE = SubjectTypeEnum.Reader;
            reading.IS_ENABLE = enable;

            writing.GRADE_CODE = gradeCode;
            writing.COURSE_CODE = courseCode;
            writing.SUBJECT_TYPE = SubjectTypeEnum.Writing;
            writing.IS_ENABLE = enable;

            select.VERY_EASY = Convert.ToInt32(t11.Text.Trim());
            select.EASY = Convert.ToInt32(t12.Text.Trim());
            select.COMMON = Convert.ToInt32(t13.Text.Trim());
            select.DIFFICULTY = Convert.ToInt32(t14.Text.Trim());
            select.VERY_DIFFICULTY = Convert.ToInt32(t15.Text.Trim());

            fill.VERY_EASY = Convert.ToInt32(t21.Text.Trim());
            fill.EASY = Convert.ToInt32(t22.Text.Trim());
            fill.COMMON = Convert.ToInt32(t23.Text.Trim());
            fill.DIFFICULTY = Convert.ToInt32(t24.Text.Trim());
            fill.VERY_DIFFICULTY = Convert.ToInt32(t25.Text.Trim());

            judge.VERY_EASY = Convert.ToInt32(t31.Text.Trim());
            judge.EASY = Convert.ToInt32(t32.Text.Trim());
            judge.COMMON = Convert.ToInt32(t33.Text.Trim());
            judge.DIFFICULTY = Convert.ToInt32(t34.Text.Trim());
            judge.VERY_DIFFICULTY = Convert.ToInt32(t35.Text.Trim());

            eassy.VERY_EASY = Convert.ToInt32(t41.Text.Trim());
            eassy.EASY = Convert.ToInt32(t42.Text.Trim());
            eassy.COMMON = Convert.ToInt32(t43.Text.Trim());
            eassy.DIFFICULTY = Convert.ToInt32(t44.Text.Trim());
            eassy.VERY_DIFFICULTY = Convert.ToInt32(t45.Text.Trim());

            multiSelect.VERY_EASY = Convert.ToInt32(t51.Text.Trim());
            multiSelect.EASY = Convert.ToInt32(t52.Text.Trim());
            multiSelect.COMMON = Convert.ToInt32(t53.Text.Trim());
            multiSelect.DIFFICULTY = Convert.ToInt32(t54.Text.Trim());
            multiSelect.VERY_DIFFICULTY = Convert.ToInt32(t55.Text.Trim());

            reading.VERY_EASY = Convert.ToInt32(t61.Text.Trim());
            reading.EASY = Convert.ToInt32(t62.Text.Trim());
            reading.COMMON = Convert.ToInt32(t63.Text.Trim());
            reading.DIFFICULTY = Convert.ToInt32(t64.Text.Trim());
            reading.VERY_DIFFICULTY = Convert.ToInt32(t65.Text.Trim());

            writing.VERY_EASY = Convert.ToInt32(t71.Text.Trim());
            writing.EASY = Convert.ToInt32(t72.Text.Trim());
            writing.COMMON = Convert.ToInt32(t73.Text.Trim());
            writing.DIFFICULTY = Convert.ToInt32(t74.Text.Trim());
            writing.VERY_DIFFICULTY = Convert.ToInt32(t75.Text.Trim());

            var guid = Guid.NewGuid().ToString().Replace("-", "");
            var exams = new List<ExamBank>();
            if (isAdd)
            {
                select.EXAM_GUID = guid;
                fill.EXAM_GUID = guid;
                multiSelect.EXAM_GUID = guid;
                eassy.EXAM_GUID = guid;
                writing.EXAM_GUID = guid;
                reading.EXAM_GUID = guid;
                judge.EXAM_GUID = guid;
            }
            exams.Add(select);
            exams.Add(multiSelect);
            exams.Add(fill);
            exams.Add(eassy);
            exams.Add(reading);
            exams.Add(writing);
            exams.Add(judge);
            if (isAdd)
            {
                bankService.AddExamBank(exams);
            }
            else
            {
                bankService.UpdateExamBank(exams);
            }
            ShowMsg("提交成功");
            action?.Invoke();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(ShowAffirm("是否退出当前界面？") == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
