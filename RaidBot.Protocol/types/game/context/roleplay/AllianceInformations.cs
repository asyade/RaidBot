using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AllianceInformations : BasicNamedAllianceInformations
{

	public const uint Id = 417;
	public override uint MessageId { get { return Id; } }

	public GuildEmblem AllianceEmblem { get; set; }

	public AllianceInformations() {}


	public AllianceInformations InitAllianceInformations(GuildEmblem AllianceEmblem)
	{
		this.AllianceEmblem = AllianceEmblem;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.AllianceEmblem.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.AllianceEmblem = new GuildEmblem();
		this.AllianceEmblem.Deserialize(reader);
	}
}
}
