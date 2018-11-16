


















// Generated on 06/26/2015 11:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyMemberRemoveMessage : AbstractPartyEventMessage
{

public const uint Id = 5579;
public override uint MessageId
{
    get { return Id; }
}

public uint leavingPlayerId;
        

public PartyMemberRemoveMessage()
{
}

public PartyMemberRemoveMessage(uint partyId, uint leavingPlayerId)
         : base(partyId)
        {
            this.leavingPlayerId = leavingPlayerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(leavingPlayerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            leavingPlayerId = reader.ReadVaruhint();
            if (leavingPlayerId < 0)
                throw new Exception("Forbidden value on leavingPlayerId = " + leavingPlayerId + ", it doesn't respect the following condition : leavingPlayerId < 0");
            

}


}


}