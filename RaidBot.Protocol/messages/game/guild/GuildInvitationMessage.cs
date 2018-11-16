


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildInvitationMessage : NetworkMessage
{

public const uint Id = 5551;
public override uint MessageId
{
    get { return Id; }
}

public uint targetId;
        

public GuildInvitationMessage()
{
}

public GuildInvitationMessage(uint targetId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(targetId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

targetId = reader.ReadVaruhint();
            if (targetId < 0)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < 0");
            

}


}


}