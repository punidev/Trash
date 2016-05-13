using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptoCourse
{
    public class Crypto
    {
        public static void CryptFile(string fileIn, string fileOut, SymmetricAlgorithm algo, byte[] rgbKey, byte[] rgbIv)
        {
            if (string.IsNullOrEmpty(fileIn))
                throw new FileNotFoundException(string.Format("Неверный путь к файлу: {0}.", fileIn));
            if (!File.Exists(fileIn))
                throw new FileNotFoundException(string.Format("Файл '{0}' не найден.", fileIn));
            const string cryptExt = ".crypt";
            using (var sa = algo)
            using (var fsw = File.Open(fileOut + cryptExt, FileMode.Create, FileAccess.Write))
            using (var cs = new CryptoStream(fsw, sa.CreateEncryptor(rgbKey, rgbIv), CryptoStreamMode.Write))
            {
                byte[] buff;
                using (var fs = File.Open(fileIn, FileMode.Open, FileAccess.Read))
                {
                    buff = new byte[fs.Length + sizeof(long)];
                    fs.Read(buff, sizeof(long), buff.Length - sizeof(long));
                    var i = 0;
                    foreach (byte _byte in BitConverter.GetBytes(fs.Length))
                        buff[i++] = _byte;
                }

                cs.Write(buff, 0, buff.Length);
                cs.Flush();
            }
            Array.Clear(rgbKey, 0, rgbKey.Length);
            Array.Clear(rgbIv, 0, rgbIv.Length);
        }

        public static void DecryptFile(string name, string fileIn, string fileOut, SymmetricAlgorithm algo, byte[] rgbKey, byte[] rgbIv)
        {
            if (string.IsNullOrEmpty(fileIn))
                throw new FileNotFoundException(string.Format("Неверный путь к файлу: {0}.", fileIn));

            if (!File.Exists(fileIn))
                throw new FileNotFoundException(string.Format("Файл '{0}' не найден.", fileIn));
            using (var sa = algo)
            using (var fsr = File.Open(fileIn, FileMode.Open, FileAccess.Read))
            using (var cs = new CryptoStream(fsr, sa.CreateDecryptor(rgbKey, rgbIv), CryptoStreamMode.Read))
            {
                var buff = new byte[fsr.Length];
                cs.Read(buff, 0, buff.Length);
                //
                using (var fsw = File.Open(name + "\\decrypted_" + fileOut, FileMode.Create, FileAccess.Write))
                //
                {
                    var len = (int)BitConverter.ToInt64(buff, 0);
                    fsw.Write(buff, sizeof(long), len);
                    fsw.Flush();
                }
            }

            Array.Clear(rgbKey, 0, rgbKey.Length);
            Array.Clear(rgbIv, 0, rgbIv.Length);
        }
        
    }
}
