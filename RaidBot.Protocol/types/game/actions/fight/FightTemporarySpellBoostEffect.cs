using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class FightTemporarySpellBoostEffect : FightTemporaryBoostEffect
{

	public const uint Id = 207;
	public override uint MessageId { get { return Id; } }

	public short BoostedSpellId { get; set; }

	public FightTemporarySpellBoostEffect() {}


	public FightTemporarySpellBoostEffect InitFightTemporarySpellBoostEffect(short BoostedSpellId)
	{
		this.BoostedSpellId = BoostedSpellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.BoostedSpellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.BoostedSpellId = reader.ReadVarShort();
	}
}
}
