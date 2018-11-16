


















// Generated on 06/26/2015 11:41:21
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MapInformationsRequestMessage : NetworkMessage
{

public const uint Id = 225;
public override uint MessageId
{
    get { return Id; }
}

public int mapId;
        

public MapInformationsRequestMessage()
{
}

public MapInformationsRequestMessage(int mapId)
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