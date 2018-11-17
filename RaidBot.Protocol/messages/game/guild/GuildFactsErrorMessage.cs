using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildFactsErrorMessage : NetworkMessage
{

	public const uint Id = 6424;
	public override uint MessageId { get { return Id; } }

	public int GuildId { get; set; }

	public GuildFactsErrorMessage() {}


	public GuildFactsErrorMessage InitGuildFactsErrorMessage(int GuildId)
	{
		this.GuildId = GuildId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.GuildId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GuildId = reader.ReadVarInt();
	}
}
}
