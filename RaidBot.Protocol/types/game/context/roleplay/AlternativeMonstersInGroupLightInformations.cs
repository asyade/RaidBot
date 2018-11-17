using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class AlternativeMonstersInGroupLightInformations : NetworkType
{

	public const uint Id = 394;
	public override uint MessageId { get { return Id; } }

	public int PlayerCount { get; set; }
	public MonsterInGroupLightInformations[] Monsters { get; set; }

	public AlternativeMonstersInGroupLightInformations() {}


	public AlternativeMonstersInGroupLightInformations InitAlternativeMonstersInGroupLightInformations(int PlayerCount, MonsterInGroupLightInformations[] Monsters)
	{
		this.PlayerCount = PlayerCount;
		this.Monsters = Monsters;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.PlayerCount);
		writer.WriteShort(this.Monsters.Length);
		foreach (MonsterInGroupLightInformations item in this.Monsters)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PlayerCount = reader.ReadInt();
		int MonstersLen = reader.ReadShort();
		Monsters = new MonsterInGroupLightInformations[MonstersLen];
		for (int i = 0; i < MonstersLen; i++)
		{
			this.Monsters[i] = new MonsterInGroupLightInformations();
			this.Monsters[i].Deserialize(reader);
		}
	}
}
}
