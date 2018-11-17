using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightAllianceTeamInformations : FightTeamInformations
{

	public const uint Id = 439;
	public override uint MessageId { get { return Id; } }

	public byte Relation { get; set; }

	public FightAllianceTeamInformations() {}


	public FightAllianceTeamInformations InitFightAllianceTeamInformations(byte Relation)
	{
		this.Relation = Relation;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Relation);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Relation = reader.ReadByte();
	}
}
}
