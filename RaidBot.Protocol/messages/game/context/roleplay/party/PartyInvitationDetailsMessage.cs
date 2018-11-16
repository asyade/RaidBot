


















// Generated on 06/26/2015 11:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyInvitationDetailsMessage : AbstractPartyMessage
{

public const uint Id = 6263;
public override uint MessageId
{
    get { return Id; }
}

public sbyte partyType;
        public string partyName;
        public uint fromId;
        public string fromName;
        public uint leaderId;
        public Types.PartyInvitationMemberInformations[] members;
        public Types.PartyGuestInformations[] guests;
        

public PartyInvitationDetailsMessage()
{
}

public PartyInvitationDetailsMessage(uint partyId, sbyte partyType, string partyName, uint fromId, string fromName, uint leaderId, Types.PartyInvitationMemberInformations[] members, Types.PartyGuestInformations[] guests)
         : base(partyId)
        {
            this.partyType = partyType;
            this.partyName = partyName;
            this.fromId = fromId;
            this.fromName = fromName;
            this.leaderId = leaderId;
            this.members = members;
            this.guests = guests;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(partyType);
            writer.WriteUTF(partyName);
            writer.WriteVaruhint(fromId);
            writer.WriteUTF(fromName);
            writer.WriteVaruhint(leaderId);
            writer.WriteUShort((ushort)members.Length);
            foreach (var entry in members)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)guests.Length);
            foreach (var entry in guests)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            partyType = reader.ReadSByte();
            if (partyType < 0)
                throw new Exception("Forbidden value on partyType = " + partyType + ", it doesn't respect the following condition : partyType < 0");
            partyName = reader.ReadUTF();
            fromId = reader.ReadVaruhint();
            if (fromId < 0)
                throw new Exception("Forbidden value on fromId = " + fromId + ", it doesn't respect the following condition : fromId < 0");
            fromName = reader.ReadUTF();
            leaderId = reader.ReadVaruhint();
            if (leaderId < 0)
                throw new Exception("Forbidden value on leaderId = " + leaderId + ", it doesn't respect the following condition : leaderId < 0");
            var limit = reader.ReadUShort();
            members = new Types.PartyInvitationMemberInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 members[i] = new Types.PartyInvitationMemberInformations();
                 members[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            guests = new Types.PartyGuestInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 guests[i] = new Types.PartyGuestInformations();
                 guests[i].Deserialize(reader);
            }
            

}


}


}