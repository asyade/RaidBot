using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildInvitationStateRecrutedMessage : NetworkMessage
{

	public const uint Id = 5548;
	public override uint MessageId { get { return Id; } }

	public byte InvitationState { get; set; }

	public GuildInvitationStateRecrutedMessage() {}


	public GuildInvitationStateRecrutedMessage InitGuildInvitationStateRecrutedMessage(byte InvitationState)
	{
		this.InvitationState = InvitationState;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.InvitationState);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.InvitationState = reader.ReadByte();
	}
}
}
