using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class BasicGuildInformations : AbstractSocialGroupInfos
{

	public const uint Id = 365;
	public override uint MessageId { get { return Id; } }

	public int GuildId { get; set; }
	public String GuildName { get; set; }
	public byte GuildLevel { get; set; }

	public BasicGuildInformations() {}


	public BasicGuildInformations InitBasicGuildInformations(int GuildId, String GuildName, byte GuildLevel)
	{
		this.GuildId = GuildId;
		this.GuildName = GuildName;
		this.GuildLevel = GuildLevel;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.GuildId);
		writer.WriteUTF(this.GuildName);
		writer.WriteByte(this.GuildLevel);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.GuildId = reader.ReadVarInt();
		this.GuildName = reader.ReadUTF();
		this.GuildLevel = reader.ReadByte();
	}
}
}
