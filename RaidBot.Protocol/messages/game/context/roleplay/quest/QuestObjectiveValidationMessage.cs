using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class QuestObjectiveValidationMessage : NetworkMessage
{

	public const uint Id = 6085;
	public override uint MessageId { get { return Id; } }

	public short QuestId { get; set; }
	public short ObjectiveId { get; set; }

	public QuestObjectiveValidationMessage() {}


	public QuestObjectiveValidationMessage InitQuestObjectiveValidationMessage(short QuestId, short ObjectiveId)
	{
		this.QuestId = QuestId;
		this.ObjectiveId = ObjectiveId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.QuestId);
		writer.WriteVarShort(this.ObjectiveId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.QuestId = reader.ReadVarShort();
		this.ObjectiveId = reader.ReadVarShort();
	}
}
}
