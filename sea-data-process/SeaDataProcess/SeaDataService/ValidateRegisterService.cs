using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Service
{
    public class ValidateRegisterService
    {
        private static string fileName = "SeaDataProcess.dll";
        public static Tuple<bool,string> ValidateRegister()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            if (!File.Exists(path))
                return new Tuple<bool,string>(false, "注册文件不存在,请进行注册");
            else
            {
                var currentMachineInfo = RSACryptoHelper.EncryptAlgorith(Convert.ToBase64String(Encoding.UTF8.GetBytes(ComputerManager.GetInfo())));
                var s = File.ReadAllText(path);
                if (s.GetHashCode() == currentMachineInfo.GetHashCode())
                    return new Tuple<bool,string>(true, "验证成功");
                else
                    return new Tuple<bool, string>(false, "注册码不可用，请重新注册");
            }
        }


        public static async Task<bool> ResiterCode(string content)
        {
            if (string.IsNullOrEmpty(content))
                throw new Exception("请输入注册码");

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            if (File.Exists(path))
                File.Delete(path);
            using(var writer = new StreamWriter(path))
            {
                await writer.WriteAsync(content);
                writer.Flush();
            }
            return true;
        }

    }
}
