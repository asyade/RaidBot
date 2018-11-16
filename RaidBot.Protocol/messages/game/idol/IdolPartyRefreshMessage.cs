


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IdolPartyRefreshMessage : NetworkMessage
{

public const uint Id = 6583;
public override uint MessageId
{
    get { return Id; }
}

public Types.PartyIdol partyIdol;
        

public IdolPartyRefreshMessage()
{
}

public IdolPartyRefreshMessage(Types.PartyIdol partyIdol)
        {
            this.partyIdol = partyIdol;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

partyIdol.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

partyIdol = new Types.PartyIdol();
            partyIdol.Deserialize(reader);
            

}


}


}