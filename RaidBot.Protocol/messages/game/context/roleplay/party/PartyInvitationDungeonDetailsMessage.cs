


















// Generated on 06/26/2015 11:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyInvitationDungeonDetailsMessage : PartyInvitationDetailsMessage
{

public const uint Id = 6262;
public override uint MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        public bool[] playersDungeonReady;
        

public PartyInvitationDungeonDetailsMessage()
{
}

public PartyInvitationDungeonDetailsMessage(uint partyId, sbyte partyType, string partyName, uint fromId, string fromName, uint leaderId, Types.PartyInvitationMemberInformations[] members, Types.PartyGuestInformations[] guests, ushort dungeonId, bool[] playersDungeonReady)
         : base(partyId, partyType, partyName, fromId, fromName, leaderId, members, guests)
        {
            this.dungeonId = dungeonId;
            this.playersDungeonReady = playersDungeonReady;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(dungeonId);
            writer.WriteUShort((ushort)playersDungeonReady.Length);
            foreach (var entry in playersDungeonReady)
            {
                 writer.WriteBoolean(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            dungeonId = reader.ReadVaruhshort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            var limit = reader.ReadUShort();
            playersDungeonReady = new bool[limit];
            for (int i = 0; i < limit; i++)
            {
                 playersDungeonReady[i] = reader.ReadBoolean();
            }
            

}


}


}