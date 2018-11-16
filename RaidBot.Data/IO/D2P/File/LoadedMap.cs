
using RaidBot.Common.IO;
using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
namespace RaidBot.Data.IO.D2P.File
{
    public class LoadedMap
    {

        #region Declarations

        public string Path { get; set; }
        public string indexName { get; set; }
        public uint offset { get; set; }
        public uint bytesCount { get; set; }
        public bool isInvalidMap { get; set; }
        public BigEndianReader raw { get; set; }

        #endregion

        #region Constructeur

        public LoadedMap(BigEndianReader _raw, string _path)
        {
            raw = _raw;
            Path = _path;

            ReadMapInformation();
        }

        #endregion

        #region Methodes Publiques

        public uint GetMapId()
        {

                return uint.Parse(indexName.Substring(indexName.IndexOf('/') + 1).Replace(".dlm", ""));
        }

        private void ReadMapInformation()
        {
            indexName = raw.ReadUTF();

            if (indexName == "link" || indexName == "" || indexName.Contains("png") || !indexName.Contains(".dlm"))
            {
                isInvalidMap = true;
                return;
            }

            offset = raw.ReadUInt() + 2;
            bytesCount = raw.ReadUInt();
        }

      

        #endregion
    }
}
