


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class MapCoordinatesExtended : MapCoordinatesAndId
{

public const short Id = 176;
public override short TypeId
{
    get { return Id; }
}

public ushort subAreaId;
        

public MapCoordinatesExtended()
{
}

public MapCoordinatesExtended(short worldX, short worldY, int mapId, ushort subAreaId)
         : base(worldX, worldY, mapId)
        {
            this.subAreaId = subAreaId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(subAreaId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            subAreaId = reader.ReadVaruhshort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            

}


}


}