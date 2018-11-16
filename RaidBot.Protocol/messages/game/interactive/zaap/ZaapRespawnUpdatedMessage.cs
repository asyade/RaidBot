


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ZaapRespawnUpdatedMessage : NetworkMessage
{

public const uint Id = 6571;
public override uint MessageId
{
    get { return Id; }
}

public int mapId;
        

public ZaapRespawnUpdatedMessage()
{
}

public ZaapRespawnUpdatedMessage(int mapId)
        {
            this.mapId = mapId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(mapId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

mapId = reader.ReadInt();
            if (mapId < 0)
                throw new Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            

}


}


}