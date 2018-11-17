using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildModificationEmblemValidMessage : NetworkMessage
{

	public const uint Id = 6328;
	public override uint MessageId { get { return Id; } }

	public GuildEmblem GuildEmblem { get; set; }

	public GuildModificationEmblemValidMessage() {}


	public GuildModificationEmblemValidMessage InitGuildModificationEmblemValidMessage(GuildEmblem GuildEmblem)
	{
		this.GuildEmblem = GuildEmblem;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.GuildEmblem.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GuildEmblem = new GuildEmblem();
		this.GuildEmblem.Deserialize(reader);
	}
}
}
