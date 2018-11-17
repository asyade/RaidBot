using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HumanOptionGuild : HumanOption
{

	public const uint Id = 409;
	public override uint MessageId { get { return Id; } }

	public GuildInformations GuildInformations { get; set; }

	public HumanOptionGuild() {}


	public HumanOptionGuild InitHumanOptionGuild(GuildInformations GuildInformations)
	{
		this.GuildInformations = GuildInformations;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.GuildInformations.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.GuildInformations = new GuildInformations();
		this.GuildInformations.Deserialize(reader);
	}
}
}
