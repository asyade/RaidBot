using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildCreationValidMessage : NetworkMessage
{

	public const uint Id = 5546;
	public override uint MessageId { get { return Id; } }

	public String GuildName { get; set; }
	public GuildEmblem GuildEmblem { get; set; }

	public GuildCreationValidMessage() {}


	public GuildCreationValidMessage InitGuildCreationValidMessage(String GuildName, GuildEmblem GuildEmblem)
	{
		this.GuildName = GuildName;
		this.GuildEmblem = GuildEmblem;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.GuildName);
		this.GuildEmblem.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GuildName = reader.ReadUTF();
		this.GuildEmblem = new GuildEmblem();
		this.GuildEmblem.Deserialize(reader);
	}
}
}
