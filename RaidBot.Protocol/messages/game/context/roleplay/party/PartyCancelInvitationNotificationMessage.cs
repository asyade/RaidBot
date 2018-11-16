


















// Generated on 06/26/2015 11:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
{

public const uint Id = 6251;
public override uint MessageId
{
    get { return Id; }
}

public uint cancelerId;
        public uint guestId;
        

public PartyCancelInvitationNotificationMessage()
{
}

public PartyCancelInvitationNotificationMessage(uint partyId, uint cancelerId, uint guestId)
         : base(partyId)
        {
            this.cancelerId = cancelerId;
            this.guestId = guestId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(cancelerId);
            writer.WriteVaruhint(guestId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            cancelerId = reader.ReadVaruhint();
            if (cancelerId < 0)
                throw new Exception("Forbidden value on cancelerId = " + cancelerId + ", it doesn't respect the following condition : cancelerId < 0");
            guestId = reader.ReadVaruhint();
            if (guestId < 0)
                throw new Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0");
            

}


}


}