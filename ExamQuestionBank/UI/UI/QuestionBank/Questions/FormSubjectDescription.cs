using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using System;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormSubjectDescription : FormDialog
    {
        public FormSubjectDescription(SubjectDescriptionService descriptionService)
        {
            InitializeComponent();
            this.descriptionService = descriptionService;
        }
        private readonly SubjectDescriptionService descriptionService;
        private SubjectDescription subjectDescription;
        private bool isAdd = true;
        private Action action;
        private DisplayQuestionView questionView;
        private void FormSubjectDescription_Load(object sender, EventArgs e)
        {
            InitialUI();
        }

        private void InitialUI()
        {
            subjectDescription = descriptionService.GetSubjectDescription(questionView.SUBJECT_GUID);
            if(subjectDescription == null)
            {
                subjectDescription = new SubjectDescription { SUBJECT_GUID = questionView.SUBJECT_GUID };
                isAdd = true;
            }
            else
            {
                tDescription.Text = subjectDescription.DESCRIPTION;
                isAdd = false;
            }
        }

        public override void Shower(Action action, bool isAdd, object content)
        {
            this.action = action;
            this.isAdd = isAdd;
            questionView = (DisplayQuestionView)content;
            ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var des = tDescription.Text.Trim();
            if (string.IsNullOrEmpty(des))
            {
                ShowMsg("未输入任何内容");
                return;
            }
            subjectDescription.DESCRIPTION = des;
            if (isAdd)
            {
                var id = descriptionService.AddQuestionDescription(subjectDescription);
            }
            else
            {
                descriptionService.UpdateQuestionDescription(subjectDescription);
            }
            isAdd = false;
            ShowMsg("提交成功");
            action?.Invoke();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(subjectDescription.SUBJECT_GUID))
            {
                ShowMsg("数据库中不存在该问题背景材料，无法删除");
                return;
            }
            if(ShowAffirm("是否删除背景材料？\r\n确认删除，所有与该描述相关的问题无法显示背景材料") == DialogResult.OK)
            {
                descriptionService.DeleteQuestionDescription(subjectDescription);
            }
            ShowMsg("删除成功");
            action?.Invoke();
            var c = subjectDescription.SUBJECT_GUID;
            subjectDescription = new SubjectDescription
            {
                SUBJECT_GUID = c
            };
            isAdd = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(ShowAffirm("是否退出当前界面？") == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
