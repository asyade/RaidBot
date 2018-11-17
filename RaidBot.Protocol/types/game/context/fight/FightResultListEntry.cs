using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightResultListEntry : NetworkType
{

	public const uint Id = 16;
	public override uint MessageId { get { return Id; } }

	public short Outcome { get; set; }
	public byte Wave { get; set; }
	public FightLoot Rewards { get; set; }

	public FightResultListEntry() {}


	public FightResultListEntry InitFightResultListEntry(short Outcome, byte Wave, FightLoot Rewards)
	{
		this.Outcome = Outcome;
		this.Wave = Wave;
		this.Rewards = Rewards;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.Outcome);
		writer.WriteByte(this.Wave);
		this.Rewards.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Outcome = reader.ReadVarShort();
		this.Wave = reader.ReadByte();
		this.Rewards = new FightLoot();
		this.Rewards.Deserialize(reader);
	}
}
}
