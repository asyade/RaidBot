using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildJoinedMessage : NetworkMessage
{

	public const uint Id = 5564;
	public override uint MessageId { get { return Id; } }

	public GuildInformations GuildInfo { get; set; }
	public int MemberRights { get; set; }

	public GuildJoinedMessage() {}


	public GuildJoinedMessage InitGuildJoinedMessage(GuildInformations GuildInfo, int MemberRights)
	{
		this.GuildInfo = GuildInfo;
		this.MemberRights = MemberRights;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.GuildInfo.Serialize(writer);
		writer.WriteVarInt(this.MemberRights);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GuildInfo = new GuildInformations();
		this.GuildInfo.Deserialize(reader);
		this.MemberRights = reader.ReadVarInt();
	}
}
}
