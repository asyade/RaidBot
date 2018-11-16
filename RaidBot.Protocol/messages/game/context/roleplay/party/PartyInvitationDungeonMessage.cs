


















// Generated on 06/26/2015 11:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyInvitationDungeonMessage : PartyInvitationMessage
{

public const uint Id = 6244;
public override uint MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        

public PartyInvitationDungeonMessage()
{
}

public PartyInvitationDungeonMessage(uint partyId, sbyte partyType, string partyName, sbyte maxParticipants, uint fromId, string fromName, uint toId, ushort dungeonId)
         : base(partyId, partyType, partyName, maxParticipants, fromId, fromName, toId)
        {
            this.dungeonId = dungeonId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(dungeonId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            dungeonId = reader.ReadVaruhshort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            

}


}


}