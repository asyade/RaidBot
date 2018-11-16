


















// Generated on 06/26/2015 11:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildKickRequestMessage : NetworkMessage
{

public const uint Id = 5887;
public override uint MessageId
{
    get { return Id; }
}

public uint kickedId;
        

public GuildKickRequestMessage()
{
}

public GuildKickRequestMessage(uint kickedId)
        {
            this.kickedId = kickedId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(kickedId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

kickedId = reader.ReadVaruhint();
            if (kickedId < 0)
                throw new Exception("Forbidden value on kickedId = " + kickedId + ", it doesn't respect the following condition : kickedId < 0");
            

}


}


}