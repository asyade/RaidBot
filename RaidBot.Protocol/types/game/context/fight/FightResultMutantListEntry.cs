using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightResultMutantListEntry : FightResultFighterListEntry
{

	public const uint Id = 216;
	public override uint MessageId { get { return Id; } }

	public short Level { get; set; }

	public FightResultMutantListEntry() {}


	public FightResultMutantListEntry InitFightResultMutantListEntry(short Level)
	{
		this.Level = Level;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.Level);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Level = reader.ReadVarShort();
	}
}
}
