using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileVerifier
{
    class MyFile
    {
        private String fileName_;
        private FileStream stream_;
        private bool opened_;
        private String md5Hash_;
        private String sha1Hash_;
        private String crc32Hash_;

        public String FileName
        {
            get
            {
                return fileName_;
            }
        }

        public bool Opened
        {
            get
            {
                return opened_;
            }
        }

        public String MD5Hash
        {
            get
            {
                if (!opened_)
                    throw new Exception("文件未打开");
                if (md5Hash_ == null)
                    md5Hash_ = Hasher.GetMD5Hash(stream_);
                return md5Hash_;
            }
        }

        public String SHA1Hash
        {
            get
            {
                if (!opened_)
                    throw new Exception("文件未打开");
                if (sha1Hash_ == null)
                    sha1Hash_ = Hasher.GetSHA1Hash(stream_);
                return sha1Hash_;
            }
        }

        public String CRC32Hash
        {
            get
            {
                if (!opened_)
                    throw new Exception("文件未打开");
                if (crc32Hash_ == null)
                    crc32Hash_ = Hasher.GetCRC32Hash(stream_);
                return crc32Hash_;
            }
        }

        public MyFile(String fileName)
        {
            fileName_ = fileName;
            opened_ = false;
            stream_ = null;
            md5Hash_ = null;
            sha1Hash_ = null;
            crc32Hash_ = null;
        }

        public void Open()
        {
            // 检查文件是否存在。
            FileInfo fi = new FileInfo(fileName_);
            if (!fi.Exists)
                throw new Exception("文件" + fileName_ + "不存在");

            // 创建文件流。
            stream_ = new FileStream(fileName_, FileMode.Open, FileAccess.Read);

            opened_ = true;
        }

        public void Close()
        {
            if (stream_ != null)
                stream_.Close();
            opened_ = false;
        }
    }
}
