using CustomerUI.DBService.QuestionService;
using CustomerUI.Model.QuestionBankModel;
using CustomerUI.UI.BaseForm;
using System;
using System.Drawing;
using System.Linq;

namespace CustomerUI.UI.QuestionBank
{
    public partial class FormQuestionImages : FormDialog
    {
        public FormQuestionImages(QuestionImageService imageService)
        {
            InitializeComponent();
            this.imageService = imageService;
        }
        private readonly QuestionImageService imageService;
        private QuestionImage first = new QuestionImage();
        private QuestionImage second = new QuestionImage();
        private QuestionImage third = new QuestionImage();
        private bool isAdd = true;
        private DisplayQuestionView view;
        private Action action;

        public override void Shower(Action action, bool isAdd, object content)
        {
            this.action = action;
            this.isAdd = isAdd;
            view = (DisplayQuestionView)content;

            ShowDialog();
        }

        private void FormQuestionImages_Load(object sender, EventArgs e)
        {
            InitialUI();
            InitialData();
        }
        private void InitialData()
        {
            var guid = view.QUESTION_GUID;
            first.QUESTION_GUID = guid;
            second.QUESTION_GUID = guid;
            third.QUESTION_GUID = guid;
            var r = imageService.GetQuestionImages(guid).ToList();
            if (r.Count == 0)
                return;
            var count = r.Count;
            if (count >= 1)
            {
                first = r[0];
                editFirst.DisplayImage(first.IMAGE);
            }
            if(count >= 2)
            {
                second = r[1];
                editSecond.DisplayImage(second.IMAGE);
            }
            if(count >= 3)
            {
                third = r[2];
                editThird.DisplayImage(third.IMAGE);
            }

            
        }

        private void InitialUI()
        {
            editFirst.btnDelete.Click += EditImage_Delete_Click;
            editSecond.btnDelete.Click += Second_Delete_Click;
            editThird.btnDelete.Click += BtnDelete_Click;

            editFirst.btnSubmit.Click += BtnSubmit_Click;
            editSecond.btnSubmit.Click += BtnSubmit_Second_Click;
            editThird.btnSubmit.Click += BtnSubmit_Third_Click;
        }

        private void BtnSubmit_Third_Click(object sender, EventArgs e)
        {
            if(editThird.displayPic.Image != null)
            {
                third.IMAGE = new Bitmap(editThird.displayPic.Image);
                if (third.ID != -1 && !string.IsNullOrEmpty(third.IMAGE_CONTENT))
                {
                    imageService.UpdateImage(third);
                }
                else if (third.ID == -1 && !string.IsNullOrEmpty(third.IMAGE_CONTENT))
                {
                    var r = imageService.AddImage(third);
                    third.ID = r;
                }
                ShowMsg("提交成功");
            }           
        }

        private void BtnSubmit_Second_Click(object sender, EventArgs e)
        {
            if(editSecond.displayPic.Image != null)
            {
                second.IMAGE = new Bitmap(editSecond.displayPic.Image);
                if (second.ID != -1 && !string.IsNullOrEmpty(second.IMAGE_CONTENT))
                {
                    imageService.UpdateImage(second);
                }
                else if (second.ID == -1 && !string.IsNullOrEmpty(second.IMAGE_CONTENT))
                {
                   var r = imageService.AddImage(second);
                    second.ID = r;
                }
                ShowMsg("提交成功");
            }
            
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (editFirst.displayPic.Image != null)
            {

                first.IMAGE = new Bitmap(editFirst.displayPic.Image);

                if (first.ID != -1 && !string.IsNullOrEmpty(first.IMAGE_CONTENT))
                {
                    imageService.UpdateImage(first);
                }
                else if (first.ID == -1 && !string.IsNullOrEmpty(first.IMAGE_CONTENT))
                {
                    var r = imageService.AddImage(first);
                    first.ID = r;
                }
                ShowMsg("提交成功");
            }
        }
        /// <summary>
        /// third
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (third.ID != -1)
            {
                imageService.DeleteQuestinImage(third);
                editThird.ClearImage();
                ShowMsg("删除成功");
            }
        }
        /// <summary>
        /// second
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Second_Delete_Click(object sender, EventArgs e)
        {
            if (second.ID != -1)
            {
                imageService.DeleteQuestinImage(second);
                editSecond.ClearImage();
                ShowMsg("删除成功");
            }
        }
        /// <summary>
        /// third
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditImage_Delete_Click(object sender, EventArgs e)
        {
            if (first.ID != -1)
            {
                imageService.DeleteQuestinImage(first);
                editFirst.ClearImage();
                ShowMsg("删除成功");
            }
        }
    }
}
