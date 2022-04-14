using CommonService;
using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using DevExpress.XtraBars;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormAddQuestion : FormDialog
    {
        public FormAddQuestion(CourseService courseService,
            QuestionViewService viewService,
            GradeService gradeService)
        {
            InitializeComponent();
            this.courseService = courseService;
            this.viewService = viewService;
            this.gradeService = gradeService;
        }
        private readonly CourseService courseService;
        private readonly QuestionViewService viewService;
        private readonly GradeService gradeService;
        private bool isAdd = true;
        private Action action;
        private QuestionViewModel questionView;
        private void FormEditQuestion_Load(object sender, EventArgs e)
        {
            InitialUI();
            SetValidation();
        }

        public override void Shower(Action action, bool isAdd, object content)
        {
            this.action = action;
            this.isAdd = isAdd;

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
         //   lookupCategory.EditValueChanged += LookupCategory_EditValueChanged;
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


        private void SetValidation()
        {
            SetIsNotBlankValidation(dxValidationProvider1, lookupCategory, "请选择试题类型");
            SetIsNotBlankValidation(dxValidationProvider1, lookupGrades, "请选择所属年级");
            SetNumberValidation(dxValidationProvider1, tScore, "请输入数字");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;
            GetContent();                        
        }


        private void GetContent()
        {
            var gradeCode = lookupGrades.EditValue?.ToString();
            var level = lookupDifficulty.EditValue?.ToString();
            var difficultyLevel = (DifficultyLevelEnum)Convert.ToInt16(level);
            bool enable = false;
            if (checkEnable.Checked)
            {
                enable = true;
            }
            else
            {
                enable = false;
            }
            
            if (questionView == null)
            {
                questionView = new QuestionViewModel();
                var subject = new Subject
                {
                    COURSE_CODE = lookupCourse.EditValue?.ToString(),
                    SUBJECT_GUID = CustomerHelper.GetGuid(),
                    IS_ENABLE = enable,
                    DIFFICULTY_LEVEL = difficultyLevel,
                    GRADE_CODE = gradeCode
                };
                    
                questionView.Subject = subject;
            }

            var type = lookupCategory.EditValue?.ToString();
            var qType = (QuestionTypeEnum)Convert.ToInt16(type);
            
            var questionContent = tQuestion.Text.Trim();
            var questionGuid = CustomerHelper.GetGuid();
            var score = tScore.Text.Trim();
            var filePath = tImageFile.Text.Trim();
            var itemA = tItemA.Text.Trim();
            var itemB = tItemB.Text.Trim();
            var itemC = tItemC.Text.Trim();
            var itemD = tItemD.Text.Trim();
            var itemE = tItemE.Text.Trim();
            var itemF = tItemF.Text.Trim();
            var answer = tAnswer.Text.Trim();

            // set question data
            var que = new Question
            {
                SUBJECT_GUID = questionView.Subject.SUBJECT_GUID,
                QUESTION_TYPE = qType,
                QUESTION_GUID = questionGuid,
                QUESTION_CONTENT = questionContent,
                SCORE = Convert.ToInt32(score)
            };

            questionView.Subject.SUBJECT_TYPE = (SubjectTypeEnum)((int)que.QUESTION_TYPE);

               
            questionView.Questions.Add(que);
            // set question image data
            if (imageFiles != null && imageFiles.Length >0)
            {
                if(imageFiles.Length > 3)
                {
                    ShowMsg("最多上传三张图片");
                    return;
                }
                for(int i = 0; i < imageFiles.Length; i++)
                {
                    if (File.Exists(imageFiles[i]))
                    {
                        var image = Image.FromFile(imageFiles[i]);
                        var bitmap = new Bitmap(image);
                        bitmap = new Bitmap(bitmap);
                        var qi = new QuestionImage
                        {
                            QUESTION_GUID = questionGuid,
                            IMAGE = bitmap
                        };
                        questionView.QuestionImages.Add(qi);
                    }
                    else
                    {
                        throw new FileNotFoundException($"{imageFiles[i]}图片文件不存在");
                    }
                }
                
            }

            // set items data
            if (!string.IsNullOrEmpty(itemA))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = questionView.CurrentOrder,
                    ITEM_CONTENT = itemA,
                    ITEM_LABEL = "A"
                };
                questionView.QuestionItems.Add(item);
                questionView.CurrentOrder++;
            }
            if (!string.IsNullOrEmpty(itemB))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = questionView.CurrentOrder,
                    ITEM_CONTENT = itemB,
                    ITEM_LABEL = "B"
                };
                questionView.QuestionItems.Add(item);
                questionView.CurrentOrder++;
            }
            if (!string.IsNullOrEmpty(itemC))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = questionView.CurrentOrder,
                    ITEM_CONTENT = itemC,
                    ITEM_LABEL = "C"
                };
                questionView.QuestionItems.Add(item);
                questionView.CurrentOrder++;
            }
            if (!string.IsNullOrEmpty(itemD))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = questionView.CurrentOrder,
                    ITEM_CONTENT = itemD,
                    ITEM_LABEL = "D"
                };
                questionView.QuestionItems.Add(item);
                questionView.CurrentOrder++;
            }
            if (!string.IsNullOrEmpty(itemE))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = questionView.CurrentOrder,
                    ITEM_CONTENT = itemE,
                    ITEM_LABEL = "E"
                };
                questionView.QuestionItems.Add(item);
                questionView.CurrentOrder++;
            }
            if (!string.IsNullOrEmpty(itemF))
            {
                var item = new QuestionItem
                {
                    QUESTION_GUID = questionGuid,
                    QUESTION_ORDER = questionView.CurrentOrder,
                    ITEM_CONTENT = itemF,
                    ITEM_LABEL = "F"
                };
                questionView.QuestionItems.Add(item);
                questionView.CurrentOrder++;
            }

            if (!string.IsNullOrEmpty(answer))
            {
                var an = new Answer
                {
                    QUESTION_GUID = questionGuid,
                    ANSWER_CONTENT = answer
                };
                questionView.Answers.Add(an);
            }

            ClearTextContent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var description = tDescription.Text.Trim();
            // only set subject description, so this method should place in the submit method
            if (!string.IsNullOrEmpty(description))
            {
                var qd = new SubjectDescription
                {
                    SUBJECT_GUID = questionView.Subject.SUBJECT_GUID,
                    DESCRIPTION = description,
                    
                };
                questionView.QuestionDescription = qd;
            }

            if (questionView.Questions.Count() > 1)
            {
                questionView.Subject.SUBJECT_TYPE = SubjectTypeEnum.Reader;
            }

            viewService.AddQuestion(questionView);
            ShowMsg("新增成功");
            action?.Invoke();
            questionView = null;
            ClearAllText();
        }

        private void ClearTextContent()
        {
            tQuestion.Text = string.Empty;
            tScore.Text = string.Empty;
            tImageFile.Text = string.Empty;
            tItemA.Text = string.Empty;
            tItemB.Text = string.Empty;
            tItemC.Text = string.Empty;
            tItemD.Text = string.Empty;
            tItemE.Text = string.Empty;
            tItemF.Text = string.Empty;
            tAnswer.Text = string.Empty;

            imageFiles = null;
        }

        private void ClearAllText()
        {
            ClearTextContent();
            tDescription.Text = string.Empty;
        }

        private string[] imageFiles;
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.Multiselect = true;
            openDialog.RestoreDirectory = true;
            openDialog.Filter = "JPEG 图像|*.jpg|BMP 图像|*.bmp|PNG图像|*.png|其他文件|*.*";
            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                imageFiles = openDialog.FileNames;
                if(imageFiles != null && imageFiles.Length > 0)
                {
                    var sb = new StringBuilder();
                    for(int i = 0; i < imageFiles.Length; i++)
                    {
                        sb.AppendLine(imageFiles[i]);                       
                    }
                    tImageFile.Text = sb.ToString();
                }
                else
                {
                    tImageFile.Text = string.Empty;
                }
            }
        }
    }
}
