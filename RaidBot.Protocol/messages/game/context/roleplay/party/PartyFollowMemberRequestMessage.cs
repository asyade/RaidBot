


















// Generated on 06/26/2015 11:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyFollowMemberRequestMessage : AbstractPartyMessage
{

public const uint Id = 5577;
public override uint MessageId
{
    get { return Id; }
}

public uint playerId;
        

public PartyFollowMemberRequestMessage()
{
}

public PartyFollowMemberRequestMessage(uint partyId, uint playerId)
         : base(partyId)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(playerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            

}


}


}