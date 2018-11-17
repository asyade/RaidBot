using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PartyInvitationMessage : AbstractPartyMessage
{

	public const uint Id = 5586;
	public override uint MessageId { get { return Id; } }

	public byte PartyType { get; set; }
	public String PartyName { get; set; }
	public byte MaxParticipants { get; set; }
	public long FromId { get; set; }
	public String FromName { get; set; }
	public long ToId { get; set; }

	public PartyInvitationMessage() {}


	public PartyInvitationMessage InitPartyInvitationMessage(byte PartyType, String PartyName, byte MaxParticipants, long FromId, String FromName, long ToId)
	{
		this.PartyType = PartyType;
		this.PartyName = PartyName;
		this.MaxParticipants = MaxParticipants;
		this.FromId = FromId;
		this.FromName = FromName;
		this.ToId = ToId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.PartyType);
		writer.WriteUTF(this.PartyName);
		writer.WriteByte(this.MaxParticipants);
		writer.WriteVarLong(this.FromId);
		writer.WriteUTF(this.FromName);
		writer.WriteVarLong(this.ToId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.PartyType = reader.ReadByte();
		this.PartyName = reader.ReadUTF();
		this.MaxParticipants = reader.ReadByte();
		this.FromId = reader.ReadVarLong();
		this.FromName = reader.ReadUTF();
		this.ToId = reader.ReadVarLong();
	}
}
}
