using CommonService;
using CustomerUI.DBService.CommonService;
using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormEditUserExam : FormDialog
    {
        public FormEditUserExam(UserService userService,
            ExamBankService examBankService,
            UserExamService userExamService)
        {
            InitializeComponent();
            this.userService = userService;
            this.userExamService = userExamService;
            this.examBankService = examBankService;
        }
        private readonly UserService userService;
        private readonly UserExamService userExamService;
        private readonly ExamBankService examBankService;

        private bool isAdd = true;
        private DisplayUserExam display;
        private UserExam userExam = new UserExam();
        private Action action;
        private void FormEditUserExam_Load(object sender, EventArgs e)
        {
            InitialUI();
            InitialData();
        }

        private void InitialUI()
        {
            var users = userService.Query(null).Select(x => new { x.UserId, x.UserName }).ToList();
            lookUser.Properties.DataSource = users;
            lookUser.Properties.DisplayMember = "UserName";
            lookUser.Properties.ValueMember = "UserId";
            lookUser.Properties.NullText = string.Empty;
            lookUser.Properties.NullValuePrompt = "请选择用户";

            var examBanks = examBankService.GetExamBanks(null)
                                .Where(x => x.IS_ENABLE == true)
                                .Select(x => new { 考试编号 = x.EXAM_GUID, 考试科目 = x.COURSE_NAME, 年级 = x.GRADE_NAME })
                                .Distinct()
                                .ToList();
            searchExamBank.Properties.DataSource = examBanks;
            searchExamBank.Properties.DisplayMember = "考试编号";
            searchExamBank.Properties.ValueMember = "考试编号";
            searchExamBank.Properties.NullText = string.Empty;
            searchExamBank.Properties.NullValuePrompt = "请选择考试";

            SetIsNotBlankValidation(dxValidationProvider1, lookUser, "请选择用户");
            SetIsNotBlankValidation(dxValidationProvider1, searchExamBank, "请选择考试");
        }

        private void InitialData()
        {
            if (!isAdd)
            {
                lookUser.Text = display.USER_NAME;
                lookUser.EditValue = display.USER_ID;
                checkEnable.Checked = display.IS_ENABLE;
                searchExamBank.Text = display.EXAM_GUID;
                searchExamBank.EditValue = display.EXAM_GUID;

                userExam.USER_EXAM_GUID = display.USER_EXAM_GUID;
                userExam.EXAM_GUID = display.EXAM_GUID;
                userExam.IS_ENABLE = display.IS_ENABLE;
                userExam.ID = (int)display.ID;
                userExam.USER_ID = display.USER_ID;
                userExam.CREATE_DATE = display.CREATE_DATE;
            }
        }

        public override void Shower(Action action, bool isAdd, object content)
        {
            this.action = action;
            this.isAdd = isAdd;
            display = (DisplayUserExam)content;

            ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;
            var userId = lookUser.EditValue?.ToString();
            var examGuid = searchExamBank.EditValue?.ToString();
            var isEnable = checkEnable.Checked;

            userExam.USER_ID = userId;
            userExam.EXAM_GUID = examGuid;
            userExam.IS_ENABLE = isEnable;
            if (isAdd)
            {
                userExam.USER_EXAM_GUID = CustomerHelper.GetGuid();
                userExam.CREATE_DATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                userExamService.AddUserExam(userExam);
            }
            else
            {
                userExamService.UpdateUserExam(userExam);
            }
            ShowMsg("提交成功");
            action?.Invoke();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ShowAffirm("是否退出") == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
