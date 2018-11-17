using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightResultFighterListEntry : FightResultListEntry
{

	public const uint Id = 189;
	public override uint MessageId { get { return Id; } }

	public double Id_ { get; set; }
	public bool Alive { get; set; }

	public FightResultFighterListEntry() {}


	public FightResultFighterListEntry InitFightResultFighterListEntry(double Id_, bool Alive)
	{
		this.Id_ = Id_;
		this.Alive = Alive;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.Id_);
		writer.WriteBoolean(this.Alive);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Id_ = reader.ReadDouble();
		this.Alive = reader.ReadBoolean();
	}
}
}
