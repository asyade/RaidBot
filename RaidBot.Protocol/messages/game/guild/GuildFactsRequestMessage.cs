using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildFactsRequestMessage : NetworkMessage
{

	public const uint Id = 6404;
	public override uint MessageId { get { return Id; } }

	public int GuildId { get; set; }

	public GuildFactsRequestMessage() {}


	public GuildFactsRequestMessage InitGuildFactsRequestMessage(int GuildId)
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
