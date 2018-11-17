using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildModificationNameValidMessage : NetworkMessage
{

	public const uint Id = 6327;
	public override uint MessageId { get { return Id; } }

	public String GuildName { get; set; }

	public GuildModificationNameValidMessage() {}


	public GuildModificationNameValidMessage InitGuildModificationNameValidMessage(String GuildName)
	{
		this.GuildName = GuildName;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteUTF(this.GuildName);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GuildName = reader.ReadUTF();
	}
}
}
