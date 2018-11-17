using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildInformations : BasicGuildInformations
{

	public const uint Id = 127;
	public override uint MessageId { get { return Id; } }

	public GuildEmblem GuildEmblem { get; set; }

	public GuildInformations() {}


	public GuildInformations InitGuildInformations(GuildEmblem GuildEmblem)
	{
		this.GuildEmblem = GuildEmblem;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.GuildEmblem.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.GuildEmblem = new GuildEmblem();
		this.GuildEmblem.Deserialize(reader);
	}
}
}
