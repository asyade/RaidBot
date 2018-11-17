using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GroupMonsterStaticInformationsWithAlternatives : GroupMonsterStaticInformations
{

	public const uint Id = 396;
	public override uint MessageId { get { return Id; } }

	public AlternativeMonstersInGroupLightInformations[] Alternatives { get; set; }

	public GroupMonsterStaticInformationsWithAlternatives() {}


	public GroupMonsterStaticInformationsWithAlternatives InitGroupMonsterStaticInformationsWithAlternatives(AlternativeMonstersInGroupLightInformations[] Alternatives)
	{
		this.Alternatives = Alternatives;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.Alternatives.Length);
		foreach (AlternativeMonstersInGroupLightInformations item in this.Alternatives)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		int AlternativesLen = reader.ReadShort();
		Alternatives = new AlternativeMonstersInGroupLightInformations[AlternativesLen];
		for (int i = 0; i < AlternativesLen; i++)
		{
			this.Alternatives[i] = new AlternativeMonstersInGroupLightInformations();
			this.Alternatives[i].Deserialize(reader);
		}
	}
}
}
