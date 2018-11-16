


















// Generated on 06/26/2015 11:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyInvitationCancelledForGuestMessage : AbstractPartyMessage
{

public const uint Id = 6256;
public override uint MessageId
{
    get { return Id; }
}

public uint cancelerId;
        

public PartyInvitationCancelledForGuestMessage()
{
}

public PartyInvitationCancelledForGuestMessage(uint partyId, uint cancelerId)
         : base(partyId)
        {
            this.cancelerId = cancelerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(cancelerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            cancelerId = reader.ReadVaruhint();
            if (cancelerId < 0)
                throw new Exception("Forbidden value on cancelerId = " + cancelerId + ", it doesn't respect the following condition : cancelerId < 0");
            

}


}


}