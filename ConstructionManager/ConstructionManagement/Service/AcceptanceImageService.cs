using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionManagement.Model;

namespace ConstructionManagement.Service
{
    public class AcceptanceImageService:Connection
    {
        public AcceptanceImageService():base()
        {
            pathService = new PathService();
            remotePath = pathService.GetRemoteDirectoryPath();
        }

        PathService pathService;
        private string remotePath = string.Empty;
        public IList<AcceptanceImage> GetAcceptanceImages(int parentId,ImageKindEnum imagekind)
        {
            try
            {
                var query = "SELECT ID,ParentId,ProjectNo,FileName,FullFileName,RemoteFilePath,Description,ImageKind FROM AcceptanceImage WHERE ParentId=@ParentId AND ImageKind=@ImageKind";
                var result = Query<AcceptanceImage>(query, new { ImageKind = imagekind,ParentId=parentId });
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveFileToServer(Acceptance acceptance, string filePath,ImageKindEnum imageKind,string desc)
        {
            var path = filePath;
            var fullFileName = Path.GetFileName(path);
            var fileName = Path.GetFileNameWithoutExtension(path);
            var remoteFilePath = Path.Combine(remotePath, acceptance.ProjectNo, fullFileName);
            try
            {        
                if (!File.Exists(filePath)) throw new FileNotFoundException("未找到要上传到文件");                                     
                var kind = imageKind;
                if (File.Exists(remoteFilePath))
                    throw new Exception("相同文件名文件已存在");

                var acceptanceImage = new AcceptanceImage
                {
                    ParentId = acceptance.ID,
                    ProjectNo = acceptance.ProjectNo,
                    FileName = fileName,
                    FullFileName = fullFileName,
                    RemoteFilePath = remoteFilePath,
                    Description = desc,
                    ImageKind = kind
                };

                var query = "INSERT INTO AcceptanceImage (ParentId,ProjectNo,FileName,FullFileName,RemoteFilePath,Description,ImageKind) VALUES(@ParentId,@ProjectNo,@FileName,@FullFileName,@RemoteFilePath,@Description,@ImageKind)";
                Execute(query, acceptanceImage);
                var directory = Path.GetDirectoryName(remoteFilePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.Copy(path, remoteFilePath);
            }
            catch (Exception ex)
            {
                DeleteRemoteFile(remoteFilePath);
                throw;
            }
        }

        public void DeletaImagesByParentId(int parentId)
        {
            try
            {
                var query = "SELECT ID,ParentId,FileName,FullFileName,RemoteFilePath,Description,ImageKind FROM AcceptanceImage WHERE ParentId=@ParentId";
                var images = Query<AcceptanceImage>(query, new { ParentId = parentId });
                if (images.Count == 0)
                    return;
                foreach(var image in images)
                {
                    DeleteRemoteFile(image.RemoteFilePath);
                }

                var delete = "DELETE FROM AcceptanceImage WHERE ParentId=@ParentId";
                Execute(delete, new { ParentId = parentId });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteAcceptanceImage(AcceptanceImage acceptanceImage)
        {
            try
            {
                var tmp = acceptanceImage;
                if (IfAcceptanceImageExists(tmp.ID))
                {
                    var query = "DELETE FROM AcceptanceImage WHERE ID=@ID";
                    Execute(query,new { ID=tmp.ID});
                    DeleteRemoteFile(tmp.RemoteFilePath);
                }
                else
                {
                    throw new Exception("数据不存在");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void OpenLocalTmpFile(AcceptanceImage acceptanceIamge)
        {
            try
            {
                var tmp = acceptanceIamge;
                var remoteFile = tmp.RemoteFilePath;
                if (!File.Exists(remoteFile)) throw new FileNotFoundException("远程服务器不存在指定文件");

                var localtmp = pathService.GetLocalTmp(tmp.ProjectNo);
                var localPath = Path.Combine(localtmp, tmp.FullFileName);

                if (File.Exists(localPath))
                {
                    File.Delete(localPath);
                }
                File.Copy(remoteFile, localPath);
                Process.Start(localPath);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool IfAcceptanceImageExists(int id)
        {
            try
            {
                var query = "SELECT 1 FROM AcceptanceImage WHERE ID=@ID";
                var result = Query<int>(query, new { ID = id }).FirstOrDefault();
                if (result > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteRemoteFile(string filePath)
        {
            try
            {
                var remotePath = filePath;
                if (File.Exists(remotePath))
                    File.Delete(remotePath);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
