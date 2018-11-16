


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class MapCoordinatesAndId : MapCoordinates
{

public const short Id = 392;
public override short TypeId
{
    get { return Id; }
}

public int mapId;
        

public MapCoordinatesAndId()
{
}

public MapCoordinatesAndId(short worldX, short worldY, int mapId)
         : base(worldX, worldY)
        {
            this.mapId = mapId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(mapId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            mapId = reader.ReadInt();
            

}


}


}