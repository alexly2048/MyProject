using System.Drawing;
using System.IO;

namespace ConstructionManagement.Model
{
    public class SubItemImage : BaseEntity
    {
        public string ImageName { get; set; }
        public string ImageFullName { get; set; }
        public string ImageRemotePath { get; set; }
        public string ImageType { get; set; }
        public string ThumbnailRemotePath { get; set; }
        public string LocalPath { get; set; }
        public string Description { get; set; }
        public Image ThumbnailImage
        {
            get
            {
                return GetImage(ThumbnailRemotePath);
            }
        }

        public Image GetImage(string filePath)
        {
            if (!File.Exists(filePath)) return null;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var image = Image.FromStream(fs);
                fs.Close();
                fs.Dispose();
                return image;

            }
        }
    }
}
