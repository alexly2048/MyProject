using System;
using System.IO;
using System.Linq;

namespace ConstructionManagement.Service
{
    public class PathService:Connection
    {
        public PathService() : base()
        {

        }

        private readonly string localTmpDir = AppDomain.CurrentDomain.BaseDirectory;
        public string GetRemoteDirectoryPath()
        {
            try
            {
                var query = "SELECT path FROM path";
                var path = Query<string>(query).FirstOrDefault();
                if (string.IsNullOrEmpty(path)) throw new Exception("未设置远程文件夹存储路径");
                return path;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetLocalTmp(string dir)
        {
            var localDir = Path.Combine(localTmpDir, "tmp", dir);
            try
            {
                if(!Directory.Exists(localDir))
                {
                    Directory.CreateDirectory(localDir);
                }
                return localDir;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetLocalTmp()
        {
            var localDir = Path.Combine(localTmpDir, "Tmp");
            return localDir;
        }
    }
}
