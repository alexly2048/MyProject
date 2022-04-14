using Dapper.Contrib.Extensions;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CustomerUI.Model.QuestionBankModel
{
    [Table("T_QUESTION_IMAGE")]
    public class QuestionImage:BaseEntity
    {
        public string QUESTION_GUID { get; set; }

        private Image image;
        [Write(false)]
        public Image IMAGE
        {
            get
            {
                image = ConvertToImage(imageContent);
                return image;
            }
            set
            {
                image = value;
            }
        }

        private string imageContent = string.Empty;
        public string IMAGE_CONTENT
        {
            get
            {
                imageContent = ConvertToBase64(image);
                return imageContent;
            }
            set
            {
                imageContent = value;
            }
        }

        private Image ConvertToImage(string c)
        {
            if (string.IsNullOrEmpty(c)) return null;
            var s = Convert.FromBase64String(c);
            using(var m = new MemoryStream(s))
            {
                var image = new Bitmap(m);
                return image;
            }
        }

        private string ConvertToBase64(Image img)
        {
            if (img == null) return string.Empty ;
            var bitmap = new Bitmap(img);
            using(var ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                var buffer = new byte[ms.Length];
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(buffer, 0,(int)ms.Length);
                var r = Convert.ToBase64String(buffer);
                return r;
            }
           
        }
    }
}
