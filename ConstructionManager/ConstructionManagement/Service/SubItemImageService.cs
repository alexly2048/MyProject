using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using ConstructionManagement.Model;

namespace ConstructionManagement.Service
{
    public class SubItemImageService:Connection
    {
        public SubItemImageService() : base()
        {
            pathService = new PathService();
            remoteDir = pathService.GetRemoteDirectoryPath();
            localTmp = pathService.GetLocalTmp();
        }
        PathService pathService;
        private string remoteDir = string.Empty;
        private string localTmp = string.Empty;
        public IList<SubItemImage> GetImagesByParentId(int parentId)
        {
            try
            {
                var sql = "SELECT ID,ParentId,ImageName,ImageFullName,ImageRemotePath,ImageType,ThumbnailRemotePath,Description,LocalPath  FROM SubItemImage WHERE ParentId=@ParentId";
                var result = Query<SubItemImage>(sql, new { ParentId = parentId });
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddSubImage(int parentId,string filePath, string desc)
        {
            var remote = string.Empty;
            var thumbnail = string.Empty;
            var localtmp = string.Empty;
            try
            {
                if (!File.Exists(filePath)) throw new FileNotFoundException("要上传的文件不存在");

                var fileName = Path.GetFileNameWithoutExtension(filePath);
                var fullName = Path.GetFileName(filePath);
                var imageType = Path.GetExtension(filePath);
                var itemImage = new SubItemImage
                {
                    ParentId = parentId,
                    ImageName = fileName,
                    ImageFullName = fullName,
                    ImageType = imageType,
                    Description = desc
                };
                remote = GetRemoteImagePath(itemImage);
                thumbnail = GetRemoteThumbnailPath(itemImage);
                localtmp = GetLocalImagePath(itemImage);
                itemImage.ImageRemotePath = remote;
                itemImage.ThumbnailRemotePath = thumbnail;
                itemImage.LocalPath = localtmp;
                if (File.Exists(remote)) throw new Exception("相同文件名文件已存在");

                File.Copy(filePath, remote);
                SaveThumbnailToServer(filePath, thumbnail);
                var sql = "INSERT INTO SubItemImage (ParentId,ImageName,ImageFullName,ImageRemotePath,ImageType,ThumbnailRemotePath,Description,LocalPath) VALUES (@ParentId,@ImageName,@ImageFullName,@ImageRemotePath,@ImageType,@ThumbnailRemotePath,@Description,@LocalPath)";
                Execute(sql, itemImage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteSubImage(SubItemImage itemImage)
        {
            try
            {
                var sql = "DELETE FROM SubItemImage WHERE ID=@ID";
                DeleteRemoteFile(itemImage.ImageRemotePath);
                DeleteRemoteFile(itemImage.ThumbnailRemotePath);
                Execute(sql, new { ID = itemImage.ID });
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DeleteRemoteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public void SaveThumbnailToServer(string filePath,string dest)
        {
            try
            {
                Image image = Image.FromFile(filePath);
                int width = image.Width;
                if(width > 30)
                {
                    width = 30;
                }
                int heigth = image.Height;
                if(heigth > 30)
                {
                    heigth = 30;
                }
                Image newImage = new Bitmap(image, width, heigth);
                if(File.Exists(dest))
                {
                    File.Delete(dest);
                }
                newImage.Save(dest);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetRemoteImagePath(SubItemImage image)
        {
            var remote = Path.Combine(remoteDir, "Image");
            if(!Directory.Exists(remote))
            {
                Directory.CreateDirectory(remote);
            }
            remote = Path.Combine(remote, image.ParentId.ToString());
            if (!Directory.Exists(remote))
            {
                Directory.CreateDirectory(remote);
            }
            remote = Path.Combine(remote, image.ImageFullName);          
            return remote;   
        }
        public string GetRemoteThumbnailPath(SubItemImage image)
        {
            var thumbnail = Path.Combine(remoteDir, "Thumbnail");
            if (!Directory.Exists(thumbnail))
            {
                Directory.CreateDirectory(thumbnail);
            }
            thumbnail = Path.Combine(thumbnail, image.ParentId.ToString());
            if (!Directory.Exists(thumbnail))
            {
                Directory.CreateDirectory(thumbnail);
            }
            thumbnail = Path.Combine(thumbnail, image.ImageFullName);
            return thumbnail;
        }
        public string GetLocalImagePath(SubItemImage image)
        {
            var local = Path.Combine(localTmp, "Image");
            if (!Directory.Exists(local))
            {
                Directory.CreateDirectory(local);
            }
            local = Path.Combine(local, image.ParentId.ToString());
            if (!Directory.Exists(local))
            {
                Directory.CreateDirectory(local);
            }
            local = Path.Combine(local, image.ImageFullName);
            return local;
        }
        public string GetLocalThumbnailPath(SubItemImage image)
        {
            var thumbnail = Path.Combine(localTmp, "Thumbnail");
            if (!Directory.Exists(thumbnail))
            {
                Directory.CreateDirectory(thumbnail);
            }
            thumbnail = Path.Combine(thumbnail, image.ParentId.ToString());
            if (!Directory.Exists(thumbnail))
            {
                Directory.CreateDirectory(thumbnail);
            }
            thumbnail = Path.Combine(thumbnail, image.ImageFullName);
            return thumbnail;
        }

        public void DelSubItemImageByParentId(int parentId)
        {
            try
            {
                var results = GetImagesByParentId(parentId);
                foreach(var r in results)
                {
                    DeleteSubImage(r);
                }
                var sql = "DELETE FROM SubItemImage WHERE ParentId=@ParentId";
                Execute(sql, new { ParentId = parentId });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
