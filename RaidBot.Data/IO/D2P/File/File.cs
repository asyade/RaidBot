using RaidBot.Common.IO;
using System;
using System.Collections.Generic;
using System.IO;

namespace RaidBot.Data.IO.D2P.File
{
    public class File
    {
        #region Declarations

        public string Path { get; set; }
        public BigEndianReader raw { get; set; }

        public Dictionary<uint, LoadedMap> LoadedMaps { get; set; }

        #endregion

        #region Constructeur

        public File(string _path)
        {
            LoadedMaps = new Dictionary<uint, LoadedMap>();
            Path = _path;
            raw = new BigEndianReader(System.IO.File.ReadAllBytes(Path));
            GetFileContents();
        }

        #endregion

        #region Methode privee

        private void GetFileContents()
        {
            byte param1 = raw.ReadByte();
            byte param2 = raw.ReadByte();

            if ((param1 != 2) || (param2 != 1))
            {
                throw new ArgumentException("[RaidBot.Data.IO.D2P.File] Invalid D2P File");
            }


            raw.SetPosition((int)raw.BaseStream.Length - 16);
            uint Position = raw.ReadUInt();
            int LoadedMapsCount = (int)(raw.ReadUInt());
            raw.SetPosition((int)Position);


            LoadedMap LoadedMap = null;

            for (int i = 0; i <= LoadedMapsCount; i++)
            {
                LoadedMap = new LoadedMap(raw, Path);
                
                if (LoadedMap.isInvalidMap)
                    continue;

                LoadedMaps.Add(LoadedMap.GetMapId(), LoadedMap);
            }


            raw.Close();
        }

        #endregion

    }
}
