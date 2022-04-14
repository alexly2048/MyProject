using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using System;
using System.Data;
using System.Linq;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormEditQuestion : FormDialog
    {
        public FormEditQuestion(CourseService courseService,
            QuestionViewService viewService,
            QuestionItemService itemService,
            GradeService gradeService)
        {
            InitializeComponent();
            this.courseService = courseService;
            this.viewService = viewService;
            this.itemService = itemService;
            this.gradeService = gradeService;
        }
        private readonly GradeService gradeService;
        private readonly QuestionItemService itemService;
        private readonly CourseService courseService;
        private readonly QuestionViewService viewService;
        private Action action;
        private EditQuestionModel editQuestion = new EditQuestionModel();
        private DisplayQuestionView displayView;
        private void FormEditQuestion_Load(object sender, EventArgs e)
        {
            InitialUI();
            InitialData();
            SetValidation();
        }

        public override void Shower(Action action, bool isAdd, object content)
        {
            this.action = action;
            displayView = (DisplayQuestionView)content;

            ShowDialog();
        }

        private void InitialUI()
        {
            var questionTypes = QuestionType.GetQuestionTypes();
            lookupCategory.Properties.DataSource = questionTypes;
            lookupCategory.Properties.DisplayMember = "DisplayText";
            lookupCategory.Properties.ValueMember = "ValueMember";
            lookupCategory.Properties.NullValuePrompt = "请选择试题类型";
            lookupCategory.Properties.NullText = string.Empty;
            lookupCategory.ItemIndex = -1;


            var courses = courseService.GetCourses(null);
            var courseData = courses.Select(x => new { 科目编号 = x.COURSE_CODE, 科目名称 = x.COURSE_NAME });
            lookupCourse.Properties.DataSource = courseData;
            lookupCourse.Properties.DisplayMember = "科目名称";
            lookupCourse.Properties.ValueMember = "科目编号";
            lookupCourse.Properties.NullValuePrompt = "请选择考试科目";
            lookupCourse.Properties.NullText = string.Empty;
            lookupCourse.ItemIndex = -1;


            var grades = gradeService.GetGrades(null);
            var gradeData = grades.Select(x => new { 编号 = x.GRADE_CODE, 名称 = x.GRADE_NAME }).ToList();
            lookupGrades.Properties.DataSource = gradeData;
            lookupGrades.Properties.DisplayMember = "名称";
            lookupGrades.Properties.ValueMember = "编号";
            lookupCourse.Properties.NullValuePrompt = "请选择年级";
            lookupCourse.Properties.NullText = string.Empty;
            lookupGrades.ItemIndex = -1;

            var difficultyData = QuestionDifficulty.GetQuestionDifficulties();
            lookupDifficulty.Properties.DataSource = difficultyData;
            lookupDifficulty.Properties.DisplayMember = "DisplayText";
            lookupDifficulty.Properties.ValueMember = "ValueMember";
            lookupDifficulty.Properties.NullValuePrompt = "请选择难易程度";
            lookupDifficulty.Properties.NullText = string.Empty;
            lookupDifficulty.ItemIndex = -1;

        }

        private void InitialData()
        {
          //  lookupCategory.Text = displayView.QUESTION_TYPE.ToString();
          //  lookupCategory.EditValue = ((int)displayView.QUESTION_TYPE).ToString();

            var index = (int)displayView.QUESTION_TYPE;
            lookupCategory.ItemIndex = index;


            lookupCourse.Text = displayView.COURSE_NAME;
            lookupCourse.EditValue = displayView.COURSE_CODE;

            lookupGrades.Text = displayView.GRADE_NAME;
            lookupGrades.EditValue = displayView.GRADE_CODE;

            var difficultyLevelIndex =(int)displayView.DIFFICULTY_LEVEL;
            lookupDifficulty.ItemIndex = difficultyLevelIndex;

            checkEnable.Checked = displayView.IS_ENABLE;

            tQuestion.Text = displayView.QUESTION_CONTENT;
            tScore.Text = displayView.SCORE.ToString();
            tAnswer.Text = displayView.ANSWER_CONTENT;

            var s = new Subject()
            {
                SUBJECT_GUID = displayView.SUBJECT_GUID,
                ID = displayView.SUBJECT_ID,
                COURSE_CODE = displayView.COURSE_CODE,
                GRADE_CODE = displayView.GRADE_CODE,
                IS_ENABLE = displayView.IS_ENABLE,
                DIFFICULTY_LEVEL = (DifficultyLevelEnum)displayView.DIFFICULTY_LEVEL,
                SUBJECT_TYPE = displayView.SUBJECT_TYPE
            };
            editQuestion.Subject = s;

            var q = new Question
            {
                ID = displayView.QUESTION_ID,
                SUBJECT_GUID = displayView.SUBJECT_GUID,
                QUESTION_TYPE = displayView.QUESTION_TYPE,
                QUESTION_GUID = displayView.QUESTION_GUID,
                QUESTION_CONTENT = displayView.QUESTION_CONTENT,
                SCORE = displayView.SCORE
            };
            editQuestion.Question = q;

            var a = new Answer
            {
                ID = displayView.ANSWER_ID,
                ANSWER_CONTENT = displayView.ANSWER_CONTENT,
                QUESTION_GUID = displayView.QUESTION_GUID,
            };
            editQuestion.Answer = a;

            var items = itemService.GetQuestionItemsByGuid(editQuestion.Question.QUESTION_GUID).ToList();
            var count = items.Count;
            if (count == 0) return;

            if(count >= 1)
            {
                tItemA.Text = items[0].ITEM_CONTENT;
            }
            if(count >= 2)
            {
                tItemB.Text = items[1].ITEM_CONTENT;
            }
            if(count >= 3)
            {
                tItemC.Text = items[2].ITEM_CONTENT;
            }
            if(count >= 4)
            {
                tItemD.Text = items[3].ITEM_CONTENT;
            }
            if(count >= 5)
            {
                tItemE.Text = items[4].ITEM_CONTENT;
            }
            if(count >= 6)
            {
                tItemF.Text = items[5].ITEM_CONTENT;
            }           
        }

        private void SetValidation()
        {
            SetIsNotBlankValidation(dxValidationProvider1, lookupCategory, "请选择实体类型");
            SetNumberValidation(dxValidationProvider1, tScore, "请输入数字");
        }



        private void GetContent()
        {
            var type = lookupCategory.EditValue?.ToString();
            var qType = (QuestionTypeEnum)Convert.ToInt16(type);
            var questionContent = tQuestion.Text.Trim();
            var questionGuid = editQuestion.Question.QUESTION_GUID;
            var score = tScore.Text.Trim();

            var gradeCode = lookupGrades.EditValue?.ToString();
            var gradeName = lookupGrades.Text.Trim();
            var difficulty = Convert.ToInt16(lookupDifficulty.EditValue?.ToString());
            var enable = checkEnable.Checked;
            var courseCode = lookupCourse.EditValue?.ToString();

            editQuestion.Subject.GRADE_CODE = gradeCode;
            editQuestion.Subject.IS_ENABLE = enable;
            editQuestion.Subject.DIFFICULTY_LEVEL = (DifficultyLevelEnum)difficulty;
            editQuestion.Subject.COURSE_CODE = courseCode;


            var itemA = tItemA.Text.Trim();
            var itemB = tItemB.Text.Trim();
            var itemC = tItemC.Text.Trim();
            var itemD = tItemD.Text.Trim();
            var itemE = tItemE.Text.Trim();
            var itemF = tItemF.Text.Trim();
            var answer = tAnswer.Text.Trim();

            // edit question data 
            editQuestion.Question.QUESTION_TYPE = qType;
            editQuestion.Question.QUESTION_GUID = questionGuid;
            editQuestion.Question.QUESTION_CONTENT = questionContent;
            editQuestion.Question.SCORE = Convert.ToInt32(score);

            // set items data
            editQuestion.Items.Clear();
            if (!string.IsNullOrEmpty(itemA))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = editQuestion.CurrentOrder,
                    ITEM_CONTENT = itemA,
                    ITEM_LABEL = "A"
                };
                editQuestion.Items.Add(item);
                editQuestion.CurrentOrder++;
            }
            if (!string.IsNullOrEmpty(itemB))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = editQuestion.CurrentOrder,
                    ITEM_CONTENT = itemB,
                    ITEM_LABEL = "B"
                };
                editQuestion.Items.Add(item);
                editQuestion.CurrentOrder++;
            }
            if (!string.IsNullOrEmpty(itemC))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = editQuestion.CurrentOrder,
                    ITEM_CONTENT = itemC,
                    ITEM_LABEL = "C"
                };
                editQuestion.Items.Add(item);
                editQuestion.CurrentOrder++;
            }
            if (!string.IsNullOrEmpty(itemD))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = editQuestion.CurrentOrder,
                    ITEM_CONTENT = itemD,
                    ITEM_LABEL = "D"
                };
                editQuestion.Items.Add(item);
                editQuestion.CurrentOrder++;
            }
            if (!string.IsNullOrEmpty(itemE))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = editQuestion.CurrentOrder,
                    ITEM_CONTENT = itemE,
                    ITEM_LABEL = "E"
                };
                editQuestion.Items.Add(item);
                editQuestion.CurrentOrder++;
            }
            if (!string.IsNullOrEmpty(itemF))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = editQuestion.CurrentOrder,
                    ITEM_CONTENT = itemF,
                    ITEM_LABEL = "F"
                };
                editQuestion.Items.Add(item);
                editQuestion.CurrentOrder++;
            }

            if (!string.IsNullOrEmpty(answer))
            {
                var an = new Answer
                {
                    QUESTION_GUID = questionGuid,
                    ANSWER_CONTENT = answer
                };
                editQuestion.Answer = an;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            GetContent();

            viewService.UpdateQuestion(editQuestion);
            ShowMsg("更新成功");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(ShowAffirm("是否退出？") == System.Windows.Forms.DialogResult.OK)
            {
                Close();
            }
        }
    }
}
