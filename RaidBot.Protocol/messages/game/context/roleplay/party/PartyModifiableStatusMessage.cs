


















// Generated on 06/26/2015 11:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyModifiableStatusMessage : AbstractPartyMessage
{

public const uint Id = 6277;
public override uint MessageId
{
    get { return Id; }
}

public bool enabled;
        

public PartyModifiableStatusMessage()
{
}

public PartyModifiableStatusMessage(uint partyId, bool enabled)
         : base(partyId)
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