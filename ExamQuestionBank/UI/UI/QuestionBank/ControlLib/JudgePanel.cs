using CustomerUI.Model.QuestionBankModel;
using CustomerUI.Model.QuestionBankModel.View;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using System;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank.ControlLib
{
    public partial class JudgePanel : XtraUserControl,IQuestionPanel
    {
        public JudgePanel()
        {
            InitializeComponent();
        }

        public void BindingData<T>(T obj)
        {
            ClearContent();
            var local = obj as GenerateExamView;
            LOrderNo.Text = QuestionDict.QuestionTypeDict[local.Question.QUESTION_TYPE] + " " + (local.Order+1).ToString();
            LQuestion.Text = local.Question.QUESTION_CONTENT;

            if (string.IsNullOrEmpty(local.UserAnswer)) return;
            var r = JudgeAnswerEnum.Error;
            if(Enum.TryParse(local.UserAnswer,out r))
            {
                if(r == JudgeAnswerEnum.Correct)
                {
                    checkCorrect.Checked = true;
                    checkError.Checked = false;
                }
                else
                {
                    checkError.Checked = true;
                    checkCorrect.Checked = false;
                }
            }
        }

        private void ClearContent()
        {
            LOrderNo.Text = string.Empty;
            LQuestion.Text = string.Empty;
            checkCorrect.Checked = false;
            checkError.Checked = false;
        }

        public string GetAnswers()
        {
            if (checkCorrect.Checked)
                return JudgeAnswerEnum.Correct.ToString();
            if (checkError.Checked)
                return JudgeAnswerEnum.Error.ToString();
            return "NONE";
        }

        private void checkCorrect_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCorrect.Checked)
            {
                checkError.Checked = false;
            }
        }

        private void checkError_CheckedChanged(object sender, EventArgs e)
        {
            if (checkError.Checked)
            {
                checkCorrect.Checked = false;
            }
        }
    }
}
