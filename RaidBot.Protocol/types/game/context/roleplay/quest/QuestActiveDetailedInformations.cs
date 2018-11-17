using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class QuestActiveDetailedInformations : QuestActiveInformations
{

	public const uint Id = 382;
	public override uint MessageId { get { return Id; } }

	public short StepId { get; set; }
	public QuestObjectiveInformations[] Objectives { get; set; }

	public QuestActiveDetailedInformations() {}


	public QuestActiveDetailedInformations InitQuestActiveDetailedInformations(short StepId, QuestObjectiveInformations[] Objectives)
	{
		this.StepId = StepId;
		this.Objectives = Objectives;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteVarShort(this.StepId);
		writer.WriteShort(this.Objectives.Length);
		foreach (QuestObjectiveInformations item in this.Objectives)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.StepId = reader.ReadVarShort();
		int ObjectivesLen = reader.ReadShort();
		Objectives = new QuestObjectiveInformations[ObjectivesLen];
		for (int i = 0; i < ObjectivesLen; i++)
		{
			this.Objectives[i] = ProtocolTypeManager.GetInstance<QuestObjectiveInformations>(reader.ReadShort());
			this.Objectives[i].Deserialize(reader);
		}
	}
}
}
