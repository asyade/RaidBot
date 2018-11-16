


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildPaddockTeleportRequestMessage : NetworkMessage
{

public const uint Id = 5957;
public override uint MessageId
{
    get { return Id; }
}

public int paddockId;
        

public GuildPaddockTeleportRequestMessage()
{
}

public GuildPaddockTeleportRequestMessage(int paddockId)
        {
            this.paddockId = paddockId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(paddockId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

paddockId = reader.ReadInt();
            

}


}


}