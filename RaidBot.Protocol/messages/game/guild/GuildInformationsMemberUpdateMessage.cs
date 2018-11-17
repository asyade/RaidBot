using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildInformationsMemberUpdateMessage : NetworkMessage
{

	public const uint Id = 5597;
	public override uint MessageId { get { return Id; } }

	public GuildMember Member { get; set; }

	public GuildInformationsMemberUpdateMessage() {}


	public GuildInformationsMemberUpdateMessage InitGuildInformationsMemberUpdateMessage(GuildMember Member)
	{
		this.Member = Member;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.Member.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Member = new GuildMember();
		this.Member.Deserialize(reader);
	}
}
}
