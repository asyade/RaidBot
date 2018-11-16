


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AccountHouseInformations
{

public const short Id = 390;
public virtual short TypeId
{
    get { return Id; }
}

public uint houseId;
        public ushort modelId;
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        

public AccountHouseInformations()
{
}

public AccountHouseInformations(uint houseId, ushort modelId, short worldX, short worldY, int mapId, ushort subAreaId)
        {
            this.houseId = houseId;
            this.modelId = modelId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(houseId);
            writer.WriteVaruhshort(modelId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVaruhshort(subAreaId);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

houseId = reader.ReadVaruhint();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            modelId = reader.ReadVaruhshort();
            if (modelId < 0)
                throw new Exception("Forbidden value on modelId = " + modelId + ", it doesn't respect the following condition : modelId < 0");
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVaruhshort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            

}


}


}