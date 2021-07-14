﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AllShowMVC.Common
{
    public class Security
    {
        private static readonly String key = "LoveVivy"; //必須8碼
        private static readonly String iv = "LoveDiva"; //必須8碼
        
        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="original">要加密的字串</param>
        /// <returns>加密後的字串</returns>
        public static String EncryptDES(String original)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                des.Key = Encoding.ASCII.GetBytes(key);
                des.IV = Encoding.ASCII.GetBytes(iv);
                byte[] s = Encoding.ASCII.GetBytes(original);
                ICryptoTransform desencrypt = des.CreateEncryptor();
                return (BitConverter.ToString(desencrypt.TransformFinalBlock(s, 0, s.Length)).Replace("-", string.Empty));
            }
            catch
            {
                return original;
            }
        }

        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="hexString">要解密的字串</param>
        /// <returns>解密後的字串</returns>
        public static String DecryptDES(String hexString)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                des.Key = Encoding.ASCII.GetBytes(key);
                des.IV = Encoding.ASCII.GetBytes(iv);

                byte[] s = new byte[hexString.Length / 2];
                int j = 0;
                for (int i = 0; i < hexString.Length / 2; i++)
                {
                    s[i] = Byte.Parse(hexString[j].ToString() + hexString[j + 1].ToString(), System.Globalization.NumberStyles.HexNumber);
                    j += 2;
                }
                ICryptoTransform desencrypt = des.CreateDecryptor();
                return Encoding.ASCII.GetString(desencrypt.TransformFinalBlock(s, 0, s.Length));
            }
            catch
            {
                return hexString;
            }
        }
        
    }
}
