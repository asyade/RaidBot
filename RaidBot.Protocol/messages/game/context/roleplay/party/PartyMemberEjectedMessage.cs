


















// Generated on 06/26/2015 11:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyMemberEjectedMessage : PartyMemberRemoveMessage
{

public const uint Id = 6252;
public override uint MessageId
{
    get { return Id; }
}

public uint kickerId;
        

public PartyMemberEjectedMessage()
{
}

public PartyMemberEjectedMessage(uint partyId, uint leavingPlayerId, uint kickerId)
         : base(partyId, leavingPlayerId)
        {
            this.kickerId = kickerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(kickerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            kickerId = reader.ReadVaruhint();
            if (kickerId < 0)
                throw new Exception("Forbidden value on kickerId = " + kickerId + ", it doesn't respect the following condition : kickerId < 0");
            

}


}


}