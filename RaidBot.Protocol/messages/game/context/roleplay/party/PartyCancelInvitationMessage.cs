


















// Generated on 06/26/2015 11:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyCancelInvitationMessage : AbstractPartyMessage
{

public const uint Id = 6254;
public override uint MessageId
{
    get { return Id; }
}

public uint guestId;
        

public PartyCancelInvitationMessage()
{
}

public PartyCancelInvitationMessage(uint partyId, uint guestId)
         : base(partyId)
        {
            this.guestId = guestId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(guestId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            guestId = reader.ReadVaruhint();
            if (guestId < 0)
                throw new Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0");
            

}


}


}