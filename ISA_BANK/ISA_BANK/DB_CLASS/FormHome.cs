using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class FormHome
    {
        //buat encrypt data
        public static string Pulang(string text)
        {
            var b = Encoding.UTF8.GetBytes(text);
            var encrypted = Gembok().CreateEncryptor().TransformFinalBlock(b, 0, b.Length);
            return Convert.ToBase64String(encrypted);

        }
        public static string Berangkat(string encrypted)
        {
            var b = Convert.FromBase64String(encrypted);
            var decrypted = Gembok().CreateDecryptor().TransformFinalBlock(b, 0, b.Length);
            return Encoding.UTF8.GetString(decrypted);
        }

        static Aes Gembok()
        {
            var keyBytes = new byte[16];
            var skeyBytes = Encoding.UTF8.GetBytes("gabrielramareynadinemichelleanakubaya");
            Array.Copy(skeyBytes, keyBytes, Math.Min(keyBytes.Length, skeyBytes.Length));

            Aes aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.KeySize = 128;
            aes.Key = keyBytes;
            aes.IV = keyBytes;

            return aes;
        }
    }
}