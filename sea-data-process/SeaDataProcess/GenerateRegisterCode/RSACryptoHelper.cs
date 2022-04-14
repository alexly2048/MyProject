using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRegisterCode
{
    public class RSACryptoHelper
    {
        private const string publicKey = @"<RSAKeyValue><Modulus>06LBn/lXdaoBIxi2D4PzfMPjFO2qiEcF3uz4a5B4x8leAzKRwaUdq5mTgo7oZmfaZ4PiNLgBvcNUgZ1MisPsef0GDrt1WifMpihTXEbKVH7tH9Ah4VfmeTmuM1DEM9x/bY/DMOAMnFE/V+73VhEhwJgHgDkySqy3I8HgUEUvDaE=</Modulus><Exponent>AQAB</Exponent><P>23kCQ8gz+Ln/f5to/SvR96DERVgqEEU88rX6fPwUBMep8/dR6f2jfZHiXOVOfJMZrQetZXbUx/rFr0Usqlz/+w==</P><Q>9tvXtR3Cz9MwHiyQsAB5uPuzjWuizOhWKHDQLpqawzr5sAQp9GoRNSSGQ/Y3IMwGniU6VYCaEYrSMe+zjSTKEw==</Q><DP>NdUhrBSQQuMEe31YLDkyYEXrvoKYlrMU9weR8FQ4aM+8rR2t1vIixusgld6c+MtwEdP/QRL7sC2fjZUvFn6HPw==</DP><DQ>oZh2EzzBKzSPGiGIMX6OL/asqhXcw5AP3ndDAE76onR3wK5pHHNWglg/gDusCM8mQd4S2qfNs1ARmtjTy8Baew==</DQ><InverseQ>OokoHd5O1n/tOIXf/EK5THHpIuDvoLfhVfkRcNNpXFhnkQP/N+YclGtTjcVncBoSiRipOSeMf8pwHGqkaar5OA==</InverseQ><D>J6RxCHo4O74ggGZ8k+NvlItM2fq62tQS8XMKBXwGY8YAajDqxI8dQ6t8yhPizGvfqUw27xEYomcYST8hu0x/2vKERxG6si6BQL8q5MlJpPSgfxcirEtgnxpQ2vU11ZvE1D3qJqmsLgawN8M1ypIkfspml/HtLIge28i11EN7lRE=</D></RSAKeyValue>";
        private static RSACryptoServiceProvider rsaProvider = null;
        /// <summary>
        /// 生成公钥、私钥
        /// </summary>
        /// <param name="includePrivateKey">是否包含私钥</param>
        /// <returns></returns>
        private static string Export(bool includePrivateKey)
        {
            RSACryptoServiceProvider provider = CreateRSAProvicer();
            string result = provider.ToXmlString(includePrivateKey);
            return result;
        }

        /// <summary>
        /// 导入RSA密钥
        /// </summary>
        /// <param name="key">密钥</param>
        private static void ImportKey(string key)
        {
            var provider = CreateRSAProvicer();
            provider.FromXmlString(key);
        }

        /// <summary>
        /// 创建加密服务
        /// </summary>
        /// <returns>RAS加密服务</returns>
        private static RSACryptoServiceProvider CreateRSAProvicer()
        {
            if(rsaProvider == null)
            {
                CspParameters cp = new CspParameters();
                cp.KeyContainerName = "hh_rsa_key_container";
                rsaProvider = new RSACryptoServiceProvider(cp);
                rsaProvider.FromXmlString(publicKey);
            }
            return rsaProvider;
        }

        /// <summary>
        /// 对输入内容使用RSA算法进行加密签名
        /// </summary>
        /// <param name="signature">需要加密内容</param>
        /// <returns></returns>
        private static string RSASignature(string signature)
        {
            try
            {
                var md5Hash = ComputeMD5Hash(signature);
                var provider = CreateRSAProvicer();
                var formatter = new RSAPKCS1SignatureFormatter(provider);
                formatter.SetHashAlgorithm("MD5");
                var encryptSignature = formatter.CreateSignature(md5Hash);
                return Convert.ToBase64String(encryptSignature);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        /// <summary>
        /// 验证加密数据
        /// </summary>
        /// <param name="signature">原始数据</param>
        /// <param name="registrationCode">注册码</param>
        /// <returns></returns>
        private static bool RSASignatureVerify(string signature,string registrationCode)
        {
            try
            {
                var md5Hash = ComputeMD5Hash(signature);
                var provider = CreateRSAProvicer();
                var formatter = new RSAPKCS1SignatureDeformatter(provider);
                formatter.SetHashAlgorithm("MD5");
                var code = Convert.FromBase64String(registrationCode);
                var result = formatter.VerifySignature(md5Hash, code);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string EncryptAlgorith(string content)
        {
            var encryptContent = RSASignature(content);
            var hash = encryptContent.GetHashCode();
            string newContent = string.Format("{0}-{1}-{2}", hash, encryptContent, hash);
            return RSACryptoHelper.RSASignature(newContent);
        }

        /// <summary>
        /// 计算内容MD5值
        /// </summary>
        /// <param name="content">计算内容</param>
        /// <returns></returns>
        private static byte[] ComputeMD5Hash(string content)
        {
            try
            {
                var md5 = HashAlgorithm.Create("MD5");
                var buffer = Encoding.UTF8.GetBytes(content);
                return md5.ComputeHash(buffer);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
