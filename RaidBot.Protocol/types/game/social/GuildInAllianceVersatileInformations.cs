using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildInAllianceVersatileInformations : GuildVersatileInformations
{

	public const uint Id = 437;
	public override uint MessageId { get { return Id; } }

	public int AllianceId { get; set; }

	public GuildInAllianceVersatileInformations() {}


	public GuildInAllianceVersatileInformations InitGuildInAllianceVersatileInformations(int AllianceId)
	{
		this.AllianceId = AllianceId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarInt(this.AllianceId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.AllianceId = reader.ReadVarInt();
	}
}
}
