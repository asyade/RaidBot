using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightSpellCooldownVariationMessage : AbstractGameActionMessage
{

	public const uint Id = 6219;
	public override uint MessageId { get { return Id; } }

	public double TargetId { get; set; }
	public short SpellId { get; set; }
	public short Value { get; set; }

	public GameActionFightSpellCooldownVariationMessage() {}


	public GameActionFightSpellCooldownVariationMessage InitGameActionFightSpellCooldownVariationMessage(double TargetId, short SpellId, short Value)
	{
		this.TargetId = TargetId;
		this.SpellId = SpellId;
		this.Value = Value;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.TargetId);
		writer.WriteVarShort(this.SpellId);
		writer.WriteVarShort(this.Value);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.TargetId = reader.ReadDouble();
		this.SpellId = reader.ReadVarShort();
		this.Value = reader.ReadVarShort();
	}
}
}
