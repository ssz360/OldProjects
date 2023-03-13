using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PhoneBook_Project.Classes
{

    public class EncryptDecrypt
    {
        private static string PublicKey = "aqesdwtgafvbwduhjedfrtgcvbhgfrtd";
        private static string FV = "sazxdersfrgthbvf";


        public static string EncryptString(string toEncrypt)
        {
            byte[] byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncrypt);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(PublicKey);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(FV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypt = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] encrypt = crypt.TransformFinalBlock(byteArray, 0, byteArray.Length);
            crypt.Dispose();
            return Convert.ToBase64String(encrypt);
        }

        public static string DecryptString(string toDecrept)
        {
            byte[] encryptByteArray = Convert.FromBase64String(toDecrept);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(PublicKey);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(FV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypt = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] decrypt = crypt.TransformFinalBlock(encryptByteArray, 0, encryptByteArray.Length);
            crypt.Dispose();
            return System.Text.ASCIIEncoding.ASCII.GetString(decrypt);
        }
    }
}
