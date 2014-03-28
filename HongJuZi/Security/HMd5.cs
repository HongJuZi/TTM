using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace HongJuZi.Security
{
    /// <summary>
    /// MD5加密工具类
    /// </summary>
    public class HMd5
    {
        /// <summary>
        /// 加密字符串
        /// </summary>
        /// <param name="str">需要加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static String encode(String str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encryptedBytes = md5.ComputeHash(Encoding.ASCII.GetBytes(str));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encryptedBytes.Length; i++) {
                sb.AppendFormat("{0:x2}", encryptedBytes[i]);
            }
            
            return sb.ToString(); 
        }
    }
}
