using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.Model.QuestionBankModel.View;
using CustomerUI.UI.BaseForm;
using CustomerUI.UI.QuestionBank.ControlLib;
using IOCService.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormExam : FormDialog
    {
        public FormExam(GenerateExamContentService generateService,
            UserExamService userExamService)
        {
            InitializeComponent();
            this.generateService = generateService;
            this.userExamService = userExamService;
        }
        private readonly GenerateExamContentService generateService;
        private readonly UserExamService userExamService;
        private Action action;
        private DisplayUserExam displayExam;
        private ExamView examView;
        private int questionCount = 0;
        private GenerateExamView currentExamView;
        private void FormQuestion_Load(object sender, EventArgs e)
        {
            InitialUI();           
        }
        
        public override void Shower(Action action, bool isAdd, object content)
        {
            this.action = action;
            displayExam = (DisplayUserExam)content;

            ShowDialog();
        }

        private void InitialUI()
        {
            var tmpExamView = generateService.GenerateExamContentByUserId(displayExam);
            examView = tmpExamView;
            InitialUserControl();
            DisplayGenerateExamView();
        }

        private void FormExam_Shown(object sender, EventArgs e)
        {
            splashManager.ShowWaitForm();
            try
            {
                var tmpExamView = generateService.GenerateExamContentByUserId(displayExam);
                examView = tmpExamView;
                InitialUserControl();

                SuspendLayout();
                DisplayGenerateExamView();
                ResumeLayout(false);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                splashManager.CloseWaitForm();
            }
        }
        /// <summary>
        /// 上一题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPre_Click(object sender, EventArgs e)
        {
            if(questionCount == 0)
            {
                ShowMsg("已经是第一道题");
                return;
            }
            questionCount = questionCount - 1;
         //   RemoveControlFromTablePanel();
            DisplayGenerateExamView();
        }
        /// <summary>
        /// 下一题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(questionCount == (examView.GenerateExamViews.Count -1))
            {
                ShowMsg("已经是最后一道题，请提交试卷");
                return;
            }
            GetAnswers();
         //   RemoveControlFromTablePanel();
            questionCount = questionCount + 1;
            DisplayGenerateExamView();            
        }

        private void RemoveControlFromTablePanel()
        {
            //var index = tablePanel.Controls.IndexOfKey(currentControl.Name);
            tablePanel.Controls.RemoveByKey(currentControl.Name);
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ShowAffirm("是否提交试卷？") == DialogResult.OK)
            {
                GetAnswers();
                // store exam info
                examView.CalculateScore();
                userExamService.SaveUserExamResult(displayExam, examView);

                
                var frm = AppContainer.Resolve<FormDisplayScore>();
                frm.Shower(null, true, examView);
                ShowMsg("试卷保存成功，即将关闭窗体");
                action?.Invoke();
                Close();
            }           
        }




        private void GetAnswers()
        {
            var answer = ((IQuestionPanel)currentControl).GetAnswers();
            examView.GenerateExamViews[questionCount].UserAnswer = answer;
        }


        private SingleSelectPanel selectPanel = new SingleSelectPanel();
        private MultiSelectWithFivePanel multiFivePanel = new MultiSelectWithFivePanel();
        private MultiSelectWithSixPanel multiSixPanel = new MultiSelectWithSixPanel();
        private JudgePanel judgePanel = new JudgePanel();
        private FillBlankPanel fillPanel = new FillBlankPanel();
        private EassayPanel eassayPanel = new EassayPanel();

        private UserControl currentControl;

        private void InitialUserControl()
        {
            selectPanel.Name = "SelectPanel";
            multiFivePanel.Name = "MultiFivePanel";
            multiSixPanel.Name = "MultiSixPanel";
            judgePanel.Name = "JudgePanel";
            fillPanel.Name = "FillPanel";
            eassayPanel.Name = "EassayPanel";
        }
        private void DisplayGenerateExamView()
        {
            currentExamView = examView.GenerateExamViews[questionCount];
            // set subject type
           

            var questionType = currentExamView.Question.QUESTION_TYPE;
            // set question panel
            switch (questionType)
            {
                case QuestionTypeEnum.Select:
                    DisplayQuestionInPanel(currentExamView, selectPanel);
                    break;
                case QuestionTypeEnum.MultiSelect:
                    if (currentExamView.Items.Count <= 5)
                    {
                        DisplayQuestionInPanel(currentExamView, multiFivePanel);
                    }
                    else
                    {
                        DisplayQuestionInPanel(currentExamView, multiSixPanel);
                    }
                    break;
                case QuestionTypeEnum.Judge:
                    DisplayQuestionInPanel(currentExamView, judgePanel);
                    break;
                case QuestionTypeEnum.FillBlank:
                    DisplayQuestionInPanel(currentExamView, fillPanel);
                    break;
                case QuestionTypeEnum.Eassay:
                    DisplayQuestionInPanel(currentExamView, eassayPanel);
                    break;
                case QuestionTypeEnum.Writing:
                    DisplayQuestionInPanel(currentExamView, eassayPanel);
                    break;
                default:
                    ShowMsg("不支持的题目类型，请联系系统管理员");
                    break;
            }
        }

        private void DisplayQuestionInPanel(GenerateExamView view,UserControl control)
        {
            ((IQuestionPanel)control).BindingData(view);

            
            tablePanel.BeginInit();
            tablePanel.SuspendLayout();
            this.SuspendLayout();
            var subjectType = string.Empty;
            subjectType = QuestionDict.SubjectTypeDict[currentExamView.Subject.SUBJECT_TYPE];
            labelSubjectType.Text = subjectType;
            // set subject description
            var desc = currentExamView.Description?.DESCRIPTION;
            if (string.IsNullOrEmpty(desc))
            {
                labelSubjectDescription.Text = string.Empty;
                tablePanel.Rows[2].Visible = false;
            }
            else
            {
                labelSubjectDescription.Text = desc;
                tablePanel.Rows[2].Visible = true;
            }
            // set question images
            var count = currentExamView.Images?.Count() ?? 0;
            if (count == 0)
            {
                tablePanel.Rows[3].Visible = false;
            }
            else
            {
                displayImage.DisplayImages(currentExamView.Images);
                tablePanel.Rows[3].Visible = true;
            }
            // table controls
            if(currentControl != null)
            {
                tablePanel.Controls.RemoveByKey(currentControl.Name);
            }            
            tablePanel.Controls.Add(control);
            tablePanel.SetRow(control,4);
            tablePanel.SetColumn(control,1);

            tablePanel.EndInit();
            tablePanel.ResumeLayout(false);
            tablePanel.PerformLayout();
            this.ResumeLayout(false);


            currentControl = control;
        }
    }
}
