using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
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
    public partial class FormUserExamHistory : FormDialog
    {
        public FormUserExamHistory(UserExamService userExamService)
        {
            InitializeComponent();
            this.userExamService = userExamService;
        }
        private readonly UserExamService userExamService;
        private bool isAdd = true;
        private DisplayUserExam display;
        private Action action;

        public override void Shower(Action action, bool isAdd, object content)
        {
            this.action = action;
            this.isAdd = isAdd;
            display = (DisplayUserExam)content;

            ShowDialog();
        }
        private void FormUserExamHistory_Load(object sender, EventArgs e)
        {
            InitialUI();
            InitialData();
        }

        private void InitialUI()
        {
            btnPanel.btnAdd.Visible = false;
            btnPanel.btnUpdate.Visible = false;
            btnPanel.btnDelete.Visible = false;
            btnPanel.btnQuery.Click += BtnQuery_Click;

            gridView1.TopRowChanged += TopRowChanged_Event;
            gridView1.CustomDrawRowIndicator += GridView_CustomDrawRowIndicator_Event;
            SetColumnRepMemoEdit(gridControl1);
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        IEnumerable<UserExamHistory> questions;
        private void InitialData()
        {
            var scores = userExamService.GetUserExamScores(display);
            var r = scores.FirstOrDefault();
            if (r != null)
            {
                lSingle.Text = r.SINGLE_SELECT_SCORE.ToString() +"分";
                lMulti.Text = r.MULTI_SELECT_SCORE.ToString() + "分";
                lJudge.Text = r.JUDGE_SCORE.ToString() + "分";
                lFIll.Text = r.FILL_BANK_SCORE.ToString() + "分";
                lEassay.Text = r.EASSAY_SCORE.ToString() + "分";
                lReader.Text = r.READER_SCORE.ToString() + "分";
                lWrite.Text = r.WRITING_SCORE.ToString() + "分";
                lTotal.Text = r.TOTAL_SCORE.ToString() + "分";
            }
            else
            {
                lSingle.Text =  "0分";
                lMulti.Text =      "0分";
                lJudge.Text =   "0分";
                lFIll.Text =    "0分";
                lEassay.Text =  "0分";
                lReader.Text =  "0分";
                lWrite.Text =  "0分";
                lTotal.Text = "0分";
            }

           questions = userExamService.GetUserExamHistories(display);
            if (questions.Any())
            {
                source.DataSource = questions;
            }
            else
            {
                source.DataSource = null;
            }
        }

        private void QueryData()
        {
            var key = btnPanel.textKeyword.Text.Trim();
            var r = questions.Where(x => x.QUESTION_TYPE.ToString().Contains(key));
            if (r.Any())
            {
                source.DataSource = r;
            }
            else
            {
                ShowMsg("未查询到数据");
                source.DataSource = null;
            }
        }
    }
}
