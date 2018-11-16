


















// Generated on 06/26/2015 11:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyRestrictedMessage : AbstractPartyMessage
{

public const uint Id = 6175;
public override uint MessageId
{
    get { return Id; }
}

public bool restricted;
        

public PartyRestrictedMessage()
{
}

public PartyRestrictedMessage(uint partyId, bool restricted)
         : base(partyId)
        {
            this.restricted = restricted;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(restricted);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            restricted = reader.ReadBoolean();
            

}


}


}