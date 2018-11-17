using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightTriggerGlyphTrapMessage : AbstractGameActionMessage
{

	public const uint Id = 5741;
	public override uint MessageId { get { return Id; } }

	public short MarkId { get; set; }
	public short MarkImpactCell { get; set; }
	public double TriggeringCharacterId { get; set; }
	public short TriggeredSpellId { get; set; }

	public GameActionFightTriggerGlyphTrapMessage() {}


	public GameActionFightTriggerGlyphTrapMessage InitGameActionFightTriggerGlyphTrapMessage(short MarkId, short MarkImpactCell, double TriggeringCharacterId, short TriggeredSpellId)
	{
		this.MarkId = MarkId;
		this.MarkImpactCell = MarkImpactCell;
		this.TriggeringCharacterId = TriggeringCharacterId;
		this.TriggeredSpellId = TriggeredSpellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.MarkId);
		writer.WriteVarShort(this.MarkImpactCell);
		writer.WriteDouble(this.TriggeringCharacterId);
		writer.WriteVarShort(this.TriggeredSpellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.MarkId = reader.ReadShort();
		this.MarkImpactCell = reader.ReadVarShort();
		this.TriggeringCharacterId = reader.ReadDouble();
		this.TriggeredSpellId = reader.ReadVarShort();
	}
}
}
