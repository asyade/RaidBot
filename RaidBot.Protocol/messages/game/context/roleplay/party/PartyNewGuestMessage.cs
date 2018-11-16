


















// Generated on 06/26/2015 11:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyNewGuestMessage : AbstractPartyEventMessage
{

public const uint Id = 6260;
public override uint MessageId
{
    get { return Id; }
}

public Types.PartyGuestInformations guest;
        

public PartyNewGuestMessage()
{
}

public PartyNewGuestMessage(uint partyId, Types.PartyGuestInformations guest)
         : base(partyId)
        {
            this.guest = guest;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            guest.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            guest = new Types.PartyGuestInformations();
            guest.Deserialize(reader);
            

}


}


}