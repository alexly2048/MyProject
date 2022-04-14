using CustomerUI.Model.QuestionBankModel;
using CustomerUI.Model.QuestionBankModel.View;
using DevExpress.XtraEditors;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank.ControlLib
{
    public partial class MultiSelectWithFivePanel : XtraUserControl,IQuestionPanel
    {
        public MultiSelectWithFivePanel()
        {
            InitializeComponent();
        }

        public void BindingData<T>(T obj)
        {
            ClearContent();
            var local = obj as GenerateExamView;
            var itemIndex = 0;
            var itemCount = local.Items.Count;
            var items = local.Items.OrderBy(x => x.QUESTION_ORDER).ToList();
            LOrderNo.Text = QuestionDict.QuestionTypeDict[local.Question.QUESTION_TYPE] + " " + (local.Order+1).ToString();
            LQuestion.Text = local.Question.QUESTION_CONTENT;
            if (itemIndex < itemCount)
            {
                LA.Text = items[itemIndex].ITEM_CONTENT;
                itemIndex++;
            }
            if (itemIndex < itemCount)
            {
                LB.Text = items[itemIndex].ITEM_CONTENT;
                itemIndex++;
            }
            if (itemIndex < itemCount)
            {
                LC.Text = items[itemIndex].ITEM_CONTENT;
                itemIndex++;
            }
            if (itemIndex < itemCount)
            {
                LD.Text = items[itemIndex].ITEM_CONTENT;
                itemIndex++;
            }
            if (itemIndex < itemCount)
            {
                LE.Text = items[itemIndex].ITEM_CONTENT;
                itemIndex++;
            }

            var answers = (local.UserAnswer??string.Empty).Split(',');
            if (answers.Length == 0) return;
            if (answers.Contains("A"))
                checkA.Checked = true;
            if (answers.Contains("B"))
                checkB.Checked = true;
            if (answers.Contains("C"))
                checkC.Checked = true;
            if (answers.Contains("D"))
                checkD.Checked = true;
            if (answers.Contains("E"))
                checkE.Checked = true;

        }

        private void ClearContent()
        {
            LOrderNo.Text = string.Empty;
            LQuestion.Text = string.Empty;
            LA.Text = string.Empty;
            LB.Text = string.Empty;
            LC.Text = string.Empty;
            LD.Text = string.Empty;
            LE.Text = string.Empty;
            checkA.Checked = false;
            checkB.Checked = false;
            checkC.Checked = false;
            checkD.Checked = false;
            checkE.Checked = false;
        }

        public string GetAnswers()
        {

            var answers = new StringBuilder();
            if (checkA.Checked)
                answers.Append("A,");
            if (checkB.Checked)
                answers.Append("B,");
            if (checkC.Checked)
                answers.Append("C,");
            if (checkD.Checked)
                answers.Append("D,");
            if (checkE.Checked)
                answers.Append("E");
            if (string.IsNullOrEmpty(answers.ToString()))
                return "NONE";
            return answers.ToString().Trim(',');
        }
    }
}
