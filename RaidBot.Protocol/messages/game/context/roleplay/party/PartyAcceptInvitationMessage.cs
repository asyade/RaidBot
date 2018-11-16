


















// Generated on 06/26/2015 11:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyAcceptInvitationMessage : AbstractPartyMessage
{

public const uint Id = 5580;
public override uint MessageId
{
    get { return Id; }
}



public PartyAcceptInvitationMessage()
{
}

public PartyAcceptInvitationMessage(uint partyId)
         : base(partyId)
        {
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            

}


}


}