using System;
using System.Collections.Generic;
using System.IO;
using ConstructionManagement.Model;
using ConstructionManagement.Service;

namespace ConstructionManagement.Service
{
    public class ConstructionFileService:Connection
    {
        public ConstructionFileService() : base()
        {
            pathService = new PathService();
            remoteDir = pathService.GetRemoteDirectoryPath();
            localDir = pathService.GetLocalTmp();
        }
        PathService pathService;
        string remoteDir = string.Empty;
        string localDir = string.Empty;
        public  IList<AppendixFile> GetFilesByConstructionNo(int parentId, string constructionField)
        {
            try
            {
                var select = "SELECT ID,ParentId,FileOrder,ConstructionNo,ConstructionField,FileName,FullFileName,CreateDate,FileType,FileSize,RemoteFilePath,LocalFilePath FROM AppendixFile WHERE ParentId=@ParentId AND ConstructionField=@ConstructionField";
                var result = Query<AppendixFile>(select, new { ParentId = parentId, ConstructionField = constructionField });
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public  void SaveFile(int parentId, string constructionNo, string constructionField, string filePath)
        {
            try
            {
                var fileName = Path.GetFileNameWithoutExtension(filePath);
                var fullFileName = Path.GetFileName(filePath);
                var fileSize = GetFileSize(filePath);
                var fileType = Path.GetExtension(filePath);

                var appendix = new AppendixFile
                {
                    ParentId = parentId,
                    FileName = fileName,
                    FullFileName = fullFileName,
                    ConstructionNo = constructionNo,
                    ConstructionField = constructionField,
                    FileSize = fileSize.ToString() + " byte",
                    FileType = fileType
                };

                var remotePath = GetRemoteFilePaht(appendix);
                var localPath = GetLocalFilePath(appendix);

                appendix.RemoteFilePath = remotePath;
                appendix.LocalFilePath = localPath;

                var insert = "INSERT INTO AppendixFile (ParentId,FileOrder,ConstructionNo,ConstructionField,FileName,FullFileName,CreateDate,FileType,FileSize,RemoteFilePath,LocalFilePath) VALUES (@ParentId,@FileOrder,@ConstructionNo,@ConstructionField,@FileName,@FullFileName,@CreateDate,@FileType ,@FileSize,@RemoteFilePath,@LocalFilePath)";
                Execute(insert, appendix);
                File.Copy(filePath, appendix.RemoteFilePath);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteAppendix(AppendixFile appendixFile)
        {
            try
            {
                var query = "DELETE FROM AppendixFile WHERE ID=@ID";
                Execute(query, new { ID = appendixFile.ID });
                DeleteFile(appendixFile.RemoteFilePath);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 根据父ID删除所有相关数据
        /// </summary>
        /// <param name="parentId"></param>
        public void DeleteAppendixFileByParentId(int parentId)
        {
            try
            {
                var select = "SELECT ID,ParentId,FileOrder,ConstructionNo,ConstructionField,FileName,FullFileName,CreateDate,FileType,FileSize,RemoteFilePath,LocalFilePath FROM AppendixFile WHERE ParentId=@ParentId";
                var results = Query<AppendixFile>(select,new { ParentId = parentId });
                foreach(var r in results)
                {
                    DeleteFile(r.RemoteFilePath);
                }
                var del = "DELETE FROM AppendixFile WHERE ParentId=@ParentId";
                Execute(del, new { ParentId = parentId });
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        private void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        private string GetLocalFilePath(AppendixFile appendix)
        {
            try
            {
                if (!Directory.Exists(localDir))
                {
                    Directory.CreateDirectory(localDir);
                }

                var path = Path.Combine(localDir, appendix.ConstructionNo);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path = Path.Combine(path, appendix.FullFileName);
                return path;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DownloadFile(AppendixFile appendix)
        {
            try
            {
                var dir = Path.GetDirectoryName(appendix.LocalFilePath);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                File.Copy(appendix.RemoteFilePath, appendix.LocalFilePath, true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string GetRemoteFilePaht(AppendixFile appendix)
        {
            try
            {
                if (!Directory.Exists(remoteDir))
                {
                    Directory.CreateDirectory(remoteDir);
                }

                var path = Path.Combine(remoteDir, appendix.ConstructionNo);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path = Path.Combine(path, appendix.FullFileName);
                return path;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private long GetFileSize(string filePath)
        {
            try
            {
                var fileSize = 0L;
                using(var fs = File.OpenRead(filePath))
                {
                    fileSize = fs.Length;
                    fs.Close();
                }
                return fileSize;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
