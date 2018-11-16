


















// Generated on 06/26/2015 11:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyFollowThisMemberRequestMessage : PartyFollowMemberRequestMessage
{

public const uint Id = 5588;
public override uint MessageId
{
    get { return Id; }
}

public bool enabled;
        

public PartyFollowThisMemberRequestMessage()
{
}

public PartyFollowThisMemberRequestMessage(uint partyId, uint playerId, bool enabled)
         : base(partyId, playerId)
        {
            this.enabled = enabled;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(enabled);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            enabled = reader.ReadBoolean();
            

}


}


}