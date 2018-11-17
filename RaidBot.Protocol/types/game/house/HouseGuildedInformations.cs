using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class HouseGuildedInformations : HouseInstanceInformations
{

	public const uint Id = 512;
	public override uint MessageId { get { return Id; } }

	public GuildInformations GuildInfo { get; set; }

	public HouseGuildedInformations() {}


	public HouseGuildedInformations InitHouseGuildedInformations(GuildInformations GuildInfo)
	{
		this.GuildInfo = GuildInfo;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.GuildInfo.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.GuildInfo = new GuildInformations();
		this.GuildInfo.Deserialize(reader);
	}
}
}
