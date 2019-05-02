using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DataLayer.Operations
{
    public class ODecrypt
    {
        private readonly string hash = "$1987@l3xt0th3ncr1p1t1on$1337$";

        public string decrypt(string password)
        {
            byte[] data = Convert.FromBase64String(password);
            using (MD5CryptoServiceProvider mds = new MD5CryptoServiceProvider())
            {
                byte[] keys = mds.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    string encryptedPassword = UTF8Encoding.UTF8.GetString(results);
                    return encryptedPassword;
                }
            }
        }
    }
}
