using CustomerUI.Model.QuestionBankModel;
using CustomerUI.Model.QuestionBankModel.View;
using DevExpress.XtraEditors;
using System.Linq;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank.ControlLib
{
    public partial class SingleSelectPanel : XtraUserControl, IQuestionPanel
    {
        public SingleSelectPanel()
        {
            InitializeComponent();
        }

        public void BindingData<T>(T obj)
        {
            ClearContent();
            var local = obj as GenerateExamView;
            LOrderNo.Text = QuestionDict.QuestionTypeDict[local.Question.QUESTION_TYPE] + " " + (local.Order+1).ToString();
            LQuestion.Text = local.Question.QUESTION_CONTENT;
            var index = 0;
            var items = local.Items;
            var count = items.Count();
            if (index < count)
            {
                LA.Text = items[index].ITEM_CONTENT;
                index++;
            }
            if (index < count)
            {
                LB.Text = items[index].ITEM_CONTENT;
                index++;
            }
            if (index < count)
            {
                LC.Text = items[index].ITEM_CONTENT;
                index++;
            }
            if (index < count)
            {
                LD.Text = items[index].ITEM_CONTENT;
            }


            if (string.IsNullOrEmpty(local.UserAnswer)) return;

            if (local.UserAnswer.Equals("A"))
                checkA.Checked = true;
            if (local.UserAnswer.Equals("B"))
                checkB.Checked = true;
            if (local.UserAnswer.Equals("C"))
                checkC.Checked = true;
            if (local.UserAnswer.Equals("D"))
                checkD.Checked = true;
        }

        private void ClearContent()
        {
            LOrderNo.Text = string.Empty;
            LQuestion.Text = string.Empty;
            LA.Text = string.Empty;
            LB.Text = string.Empty;
            LC.Text = string.Empty;
            LD.Text = string.Empty;
            checkA.Checked = false;
            checkB.Checked = false;
            checkC.Checked = false;
            checkD.Checked = false;

        }

        public string GetAnswers()
        {
            return checkA.Checked ? "A" : (checkB.Checked ? "B" : (checkC.Checked ? "C" : (checkD.Checked ? "D" : "NONE")));
        }

        private void checkA_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkA.Checked)
            {
                checkB.Checked = false;
                checkC.Checked = false;
                checkD.Checked = false;
            }
        }

        private void checkB_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkB.Checked)
            {
                checkA.Checked = false;
                checkC.Checked = false;
                checkD.Checked = false;
            }
        }

        private void checkC_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkC.Checked)
            {
                checkA.Checked = false;
                checkB.Checked = false;
                checkD.Checked = false;
            }
        }

        private void checkD_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkD.Checked)
            {
                checkA.Checked = false;
                checkB.Checked = false;
                checkC.Checked = false;
            }
        }
    }
}
