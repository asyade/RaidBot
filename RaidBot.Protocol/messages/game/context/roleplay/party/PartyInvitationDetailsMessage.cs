using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyInvitationDetailsMessage : AbstractPartyMessage
{

	public const uint Id = 6263;
	public override uint MessageId { get { return Id; } }

	public byte PartyType { get; set; }
	public String PartyName { get; set; }
	public long FromId { get; set; }
	public String FromName { get; set; }
	public long LeaderId { get; set; }
	public PartyInvitationMemberInformations[] Members { get; set; }
	public PartyGuestInformations[] Guests { get; set; }

	public PartyInvitationDetailsMessage() {}


	public PartyInvitationDetailsMessage InitPartyInvitationDetailsMessage(byte PartyType, String PartyName, long FromId, String FromName, long LeaderId, PartyInvitationMemberInformations[] Members, PartyGuestInformations[] Guests)
	{
		this.PartyType = PartyType;
		this.PartyName = PartyName;
		this.FromId = FromId;
		this.FromName = FromName;
		this.LeaderId = LeaderId;
		this.Members = Members;
		this.Guests = Guests;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.PartyType);
		writer.WriteUTF(this.PartyName);
		writer.WriteVarLong(this.FromId);
		writer.WriteUTF(this.FromName);
		writer.WriteVarLong(this.LeaderId);
		writer.WriteShort(this.Members.Length);
		foreach (PartyInvitationMemberInformations item in this.Members)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
		writer.WriteShort(this.Guests.Length);
		foreach (PartyGuestInformations item in this.Guests)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PartyType = reader.ReadByte();
		this.PartyName = reader.ReadUTF();
		this.FromId = reader.ReadVarLong();
		this.FromName = reader.ReadUTF();
		this.LeaderId = reader.ReadVarLong();
		int MembersLen = reader.ReadShort();
		Members = new PartyInvitationMemberInformations[MembersLen];
		for (int i = 0; i < MembersLen; i++)
		{
			this.Members[i] = ProtocolTypeManager.GetInstance<PartyInvitationMemberInformations>(reader.ReadShort());
			this.Members[i].Deserialize(reader);
		}
		int GuestsLen = reader.ReadShort();
		Guests = new PartyGuestInformations[GuestsLen];
		for (int i = 0; i < GuestsLen; i++)
		{
			this.Guests[i] = new PartyGuestInformations();
			this.Guests[i].Deserialize(reader);
		}
	}
}
}
