using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;

namespace FileVerifier
{
    class MyFileInfo
    {
        public string MD5 { get; set; }
        public string SHA1 { get; set; }
        public string CRC32 { get; set; }
        public bool Verified { get; set; }

        public string FullName { get; set; }
        public string FileName
        {
            get
            {
                return new FileInfo(FullName).Name;
            }
        }
        public bool Exists
        {
            get
            {
                return new FileInfo(FullName).Exists;
            }
        }
    }
}
