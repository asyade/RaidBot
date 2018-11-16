


















// Generated on 06/26/2015 11:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyLeaderUpdateMessage : AbstractPartyEventMessage
{

public const uint Id = 5578;
public override uint MessageId
{
    get { return Id; }
}

public uint partyLeaderId;
        

public PartyLeaderUpdateMessage()
{
}

public PartyLeaderUpdateMessage(uint partyId, uint partyLeaderId)
         : base(partyId)
        {
            this.partyLeaderId = partyLeaderId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(partyLeaderId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            partyLeaderId = reader.ReadVaruhint();
            if (partyLeaderId < 0)
                throw new Exception("Forbidden value on partyLeaderId = " + partyLeaderId + ", it doesn't respect the following condition : partyLeaderId < 0");
            

}


}


}