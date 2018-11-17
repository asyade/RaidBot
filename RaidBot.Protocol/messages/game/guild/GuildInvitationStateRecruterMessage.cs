using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildInvitationStateRecruterMessage : NetworkMessage
{

	public const uint Id = 5563;
	public override uint MessageId { get { return Id; } }

	public String RecrutedName { get; set; }
	public byte InvitationState { get; set; }

	public GuildInvitationStateRecruterMessage() {}


	public GuildInvitationStateRecruterMessage InitGuildInvitationStateRecruterMessage(String RecrutedName, byte InvitationState)
	{
		this.RecrutedName = RecrutedName;
		this.InvitationState = InvitationState;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.RecrutedName);
		writer.WriteByte(this.InvitationState);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.RecrutedName = reader.ReadUTF();
		this.InvitationState = reader.ReadByte();
	}
}
}
