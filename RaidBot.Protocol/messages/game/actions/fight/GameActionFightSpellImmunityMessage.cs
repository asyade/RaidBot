using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightSpellImmunityMessage : AbstractGameActionMessage
{

	public const uint Id = 6221;
	public override uint MessageId { get { return Id; } }

	public double TargetId { get; set; }
	public short SpellId { get; set; }

	public GameActionFightSpellImmunityMessage() {}


	public GameActionFightSpellImmunityMessage InitGameActionFightSpellImmunityMessage(double TargetId, short SpellId)
	{
		this.TargetId = TargetId;
		this.SpellId = SpellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.TargetId);
		writer.WriteVarShort(this.SpellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.TargetId = reader.ReadDouble();
		this.SpellId = reader.ReadVarShort();
	}
}
}
