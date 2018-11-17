using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildMotdSetRequestMessage : SocialNoticeSetRequestMessage
{

	public const uint Id = 6588;
	public override uint MessageId { get { return Id; } }

	public String Content { get; set; }

	public GuildMotdSetRequestMessage() {}


	public GuildMotdSetRequestMessage InitGuildMotdSetRequestMessage(String Content)
	{
		this.Content = Content;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.Content);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Content = reader.ReadUTF();
	}
}
}
