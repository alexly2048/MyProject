using CustomerUI.Model.QuestionBankModel.View;
using CustomerUI.UI.BaseForm;
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
    public partial class FormDisplayScore : FormDialog
    {
        public FormDisplayScore()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private ExamView view;
        public override void Shower(Action action, bool isAdd, object content)
        {
            view = (ExamView)content;

            lSingle.Text = view.SingleSelectScore.ToString();
            lMulti.Text = view.MultiSelectScore.ToString();
            lJudge.Text = view.JudgeScore.ToString();

            ShowDialog();
        }
    }
}
