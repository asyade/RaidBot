
using RaidBot.Common.IO;
using System;
namespace RaidBot.Data.IO.D2P.Map
{
        [Serializable()]
    public class CellData
    {

        #region Declarations
        public int floor { get; set; }
        public int losmov { get; set; }
        public int speed { get; set; }
        public uint mapChangeData { get; set; }
        public uint moveZone { get; set; }
        public int arrow { get; set; }
        public bool los { get; set; }
        public bool mov { get; set; }
        public bool visible { get; set; }
        public bool farmCell { get; set; }
        public bool blue { get; set; }
        public bool red { get; set; }
        public bool allowWalkRP { get; set; }
        public bool allowWalkFight { get; set; }
        

        #endregion

        #region Constructeur

        public CellData(BigEndianReader raw, sbyte mapVersion)
        {
            if ((raw.ReadByte() * 10) != -1280)
            {
                losmov = raw.ReadSByte();
                speed = raw.ReadByte();
                mapChangeData = raw.ReadByte();

                int tmpBits = 0;

                if (mapVersion > 5)
                {
                    moveZone = raw.ReadByte();
                }

                if (mapVersion > 7)
                {
                    tmpBits = raw.ReadByte();
                    arrow = 15 & tmpBits;
                }


                los = (losmov & 2) >> 1 == 1;
                mov = (losmov & 1) == 1;
                visible = (losmov & 64) >> 6 == 1;
                farmCell = (losmov & 32) >> 5 == 1;
                blue = (losmov & 16) >> 4 == 1;
                red = (losmov & 8) >> 3 == 1;
                allowWalkRP = (losmov & 128) >> 7 == 1;
                allowWalkFight = (losmov & 4) >> 2 == 1;
            }

        #endregion

        }
    }
}
