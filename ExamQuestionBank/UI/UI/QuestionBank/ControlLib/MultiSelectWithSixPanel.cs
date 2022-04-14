using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerUI.Model.QuestionBankModel.View;
using CustomerUI.Model.QuestionBankModel;
using DevExpress.XtraEditors;

namespace CustomerUI.UI.QuestionBank.ControlLib
{
    public partial class MultiSelectWithSixPanel : XtraUserControl,IQuestionPanel
    {
        public MultiSelectWithSixPanel()
        {
            InitializeComponent();
        }
        IList<string> answers;
        public IList<string> GetAnswer()
        {
            answers = new List<string>();
            if (checkA.Checked)
                answers.Add("A");
            if (checkB.Checked)
                answers.Add("B");
            if (checkC.Checked)
                answers.Add("C");
            if (checkD.Checked)
                answers.Add("D");
            if (checkE.Checked)
                answers.Add("E");
            if (checkF.Checked)
                answers.Add("F");
            return answers;
        }

        public void BindingData<T>(T obj)
        {
            ClearContent();
            var local = obj as GenerateExamView;
            LOrderNo.Text = QuestionDict.QuestionTypeDict[local.Question.QUESTION_TYPE] + " " + local.Order.ToString();
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
                index++;
            }
            if (index < count)
            {
                LE.Text = items[index].ITEM_CONTENT;
                index++;
            }
            if (index < count)
            {
                LF.Text = items[index].ITEM_CONTENT;
                index++;
            }

            var answers = (local.UserAnswer ?? string.Empty).Split(',');
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
            if (answers.Contains("F"))
                checkF.Checked = true;

        }

        private  void ClearContent()
        {
            LOrderNo.Text = string.Empty;
            LQuestion.Text = string.Empty;
            LA.Text = string.Empty;
            LB.Text = string.Empty;
            LC.Text = string.Empty;
            LD.Text = string.Empty;
            LE.Text = string.Empty;
            LF.Text = string.Empty;
            checkA.Checked = false;
            checkB.Checked = false;
            checkC.Checked = false;
            checkD.Checked = false;
            checkE.Checked = false;
            checkF.Checked = false;
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
                answers.Append("E,");
            if (checkF.Checked)
                answers.Append("F,");
            if (string.IsNullOrEmpty(answers.ToString()))
                return "NONE";
            return answers.ToString().Trim(',');
        }
    }
}
