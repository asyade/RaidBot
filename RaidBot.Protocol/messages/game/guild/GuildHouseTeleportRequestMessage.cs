


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildHouseTeleportRequestMessage : NetworkMessage
{

public const uint Id = 5712;
public override uint MessageId
{
    get { return Id; }
}

public uint houseId;
        

public GuildHouseTeleportRequestMessage()
{
}

public GuildHouseTeleportRequestMessage(uint houseId)
        {
            this.houseId = houseId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(houseId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

houseId = reader.ReadVaruhint();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            

}


}


}