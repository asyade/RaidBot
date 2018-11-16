


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameActionMarkedCell
{

public const short Id = 85;
public virtual short TypeId
{
    get { return Id; }
}

public ushort cellId;
        public sbyte zoneSize;
        public int cellColor;
        public sbyte cellsType;
        

public GameActionMarkedCell()
{
}

public GameActionMarkedCell(ushort cellId, sbyte zoneSize, int cellColor, sbyte cellsType)
        {
            this.cellId = cellId;
            this.zoneSize = zoneSize;
            this.cellColor = cellColor;
            this.cellsType = cellsType;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(cellId);
            writer.WriteSByte(zoneSize);
            writer.WriteInt(cellColor);
            writer.WriteSByte(cellsType);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

cellId = reader.ReadVaruhshort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            zoneSize = reader.ReadSByte();
            cellColor = reader.ReadInt();
            cellsType = reader.ReadSByte();
            

}


}


}