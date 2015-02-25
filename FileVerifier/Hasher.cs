using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace FileVerifier
{
    static class Hasher
    {
        public static String GetMD5Hash(Stream s)
        {
            // 从流首部开始计算。
            s.Seek(0, SeekOrigin.Begin);
            MD5 md5 = MD5.Create();
            return GetHexString(md5.ComputeHash(s));
        }

        public static String GetSHA1Hash(Stream s)
        {
            // 从流首部开始计算。
            s.Seek(0, SeekOrigin.Begin);
            SHA1 sha1 = SHA1.Create();
            return GetHexString(sha1.ComputeHash(s));
        }

        public static String GetCRC32Hash(Stream s)
        {
            s.Seek(0, SeekOrigin.Begin);
            return CRC32Helper.ComputeHash(s).ToString("x");
        }

        private static String GetHexString(byte[] ba)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < ba.Length; ++i)
                sb.Append(ba[i].ToString("x2"));

            return sb.ToString();
        }
    }
}
