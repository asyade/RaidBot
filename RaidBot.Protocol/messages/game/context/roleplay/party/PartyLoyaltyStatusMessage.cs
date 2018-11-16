


















// Generated on 06/26/2015 11:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyLoyaltyStatusMessage : AbstractPartyMessage
{

public const uint Id = 6270;
public override uint MessageId
{
    get { return Id; }
}

public bool loyal;
        

public PartyLoyaltyStatusMessage()
{
}

public PartyLoyaltyStatusMessage(uint partyId, bool loyal)
         : base(partyId)
        {
            this.loyal = loyal;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(loyal);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            loyal = reader.ReadBoolean();
            

}


}


}