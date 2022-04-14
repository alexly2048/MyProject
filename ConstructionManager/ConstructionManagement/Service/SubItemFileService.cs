using System;
using System.Collections.Generic;
using System.IO;
using ConstructionManagement.Model;

namespace ConstructionManagement.Service
{
    public class SubItemFileService:Connection
    {
        public SubItemFileService() : base()
        {
            pathService = new PathService();
            remoteDir = pathService.GetRemoteDirectoryPath();
            localDir = pathService.GetLocalTmp();

        }
        PathService pathService;
        private string remoteDir = string.Empty;
        private string localDir = string.Empty;
        public IList<SubItemFile> GetItemFileByParentId(int parentId)
        {
            try
            {
                var query = "SELECT ID,ParentId,FileName,FullFileName,FileType,RemoteFilePath,LocalPath,Description  FROM SubItemFile WHERE ParentId=@ParentId";
                var result = Query<SubItemFile>(query, new { ParentId = parentId });
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddItemFile(int parentId, string filePath, string desc)
        {
            var remoteFile = string.Empty;
                var fileName = Path.GetFileNameWithoutExtension(filePath);
                var fullName = Path.GetFileName(filePath);
                var fileType = Path.GetExtension(filePath);
                var itemFile = new SubItemFile
                {
                    ParentId = parentId,
                    Description = desc,
                    FileName = fileName,
                    FullFileName = fullName,
                    FileType = fileType
                };
                remoteFile = GetRemoteFilePath(itemFile);
                var localPath = GetLocalFilePath(itemFile);
                itemFile.RemoteFilePath = remoteFile;
                itemFile.LocalPath = localPath;
                if (File.Exists(remoteFile))
                {
                    throw new Exception($"相同文件名文件已存在<{remoteFile}>");
                }

                File.Copy(filePath, remoteFile);
                var query = "INSERT INTO SubItemFile (ParentId,FileName,FullFileName,FileType,RemoteFilePath,LocalPath,Description) VALUES (@ParentId,@FileName,@FullFileName,@FileType,@RemoteFilePath,@LocalPath,@Description)";
                Execute(query, itemFile);
        }

        public void DeleteItemFile(SubItemFile itemFile)
        {
                var query = "DELETE FROM SubItemFile WHERE ID=@ID";
                DeleteRemoteFile(itemFile.RemoteFilePath);
                Execute(query, new { ID = itemFile.ID });                
        }

        public void OpenLocalFile(SubItemFile itemFile)
        {
            try
            {               
                if (!File.Exists(itemFile.RemoteFilePath))
                {
                    throw new Exception("远程服务器文件不存在");
                }
                var dir = Path.GetDirectoryName(itemFile.LocalPath);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                File.Copy(itemFile.RemoteFilePath, itemFile.LocalPath, true);
                System.Diagnostics.Process.Start(itemFile.LocalPath);
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
                if (File.Exists(filePath))
                    File.Delete(filePath);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetRemoteFilePath(SubItemFile subItemFile)
        {
            try
            {
                var path = Path.Combine(remoteDir, "ItemFiles");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = Path.Combine(path, subItemFile.ParentId.ToString());
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = Path.Combine(path, subItemFile.FullFileName);
                return path;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetLocalFilePath(SubItemFile subItemFile)
        {
            try
            {
                var path = Path.Combine(localDir, "ItemFiles");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = Path.Combine(path, subItemFile.ParentId.ToString());
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = Path.Combine(path, subItemFile.FullFileName);
                return path;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteSubItemFileByParentId(int parentId)
        {
            try
            {
                var results = GetItemFileByParentId(parentId);
                foreach(var r in results)
                {
                    DeleteItemFile(r);
                }
                var sql = "DELETE FROM SubItemFile WHERE ParentId=@ParentId";
                Execute(sql, new { ParentId = parentId });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
