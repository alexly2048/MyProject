using CustomerUI.Model.QuestionBankModel;
using CustomerUI.Model.QuestionBankModel.View;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank.ControlLib
{
    public partial class EassayPanel : XtraUserControl,IQuestionPanel
    {
        public EassayPanel()
        {
            InitializeComponent();
        }

        public void BindingData<T>(T obj)
        {
            ClearContent();
            var local = obj as GenerateExamView;
            LOrderNo.Text = QuestionDict.QuestionTypeDict[local.Question.QUESTION_TYPE] + " " + (local.Order+1).ToString();
            LQuestion.Text = local.Question.QUESTION_CONTENT;

            tAnswer.Text = local.UserAnswer??string.Empty;
        }

        private void ClearContent()
        {
            LOrderNo.Text = string.Empty;
            LQuestion.Text = string.Empty;
            tAnswer.Text = string.Empty;
        }

        public string GetAnswers()
        {
            var answer = tAnswer.Text.Trim();
            return answer;
        }
    }
}
