using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceGuildLeavingMessage : NetworkMessage
{

	public const uint Id = 6399;
	public override uint MessageId { get { return Id; } }

	public bool Kicked { get; set; }
	public int GuildId { get; set; }

	public AllianceGuildLeavingMessage() {}


	public AllianceGuildLeavingMessage InitAllianceGuildLeavingMessage(bool Kicked, int GuildId)
	{
		this.Kicked = Kicked;
		this.GuildId = GuildId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Kicked);
		writer.WriteVarInt(this.GuildId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Kicked = reader.ReadBoolean();
		this.GuildId = reader.ReadVarInt();
	}
}
}
