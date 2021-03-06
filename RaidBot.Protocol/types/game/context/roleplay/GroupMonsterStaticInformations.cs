using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GroupMonsterStaticInformations : NetworkType
{

	public const uint Id = 140;
	public override uint MessageId { get { return Id; } }

	public MonsterInGroupLightInformations MainCreatureLightInfos { get; set; }
	public MonsterInGroupInformations[] Underlings { get; set; }

	public GroupMonsterStaticInformations() {}


	public GroupMonsterStaticInformations InitGroupMonsterStaticInformations(MonsterInGroupLightInformations MainCreatureLightInfos, MonsterInGroupInformations[] Underlings)
	{
		this.MainCreatureLightInfos = MainCreatureLightInfos;
		this.Underlings = Underlings;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.MainCreatureLightInfos.Serialize(writer);
		writer.WriteShort(this.Underlings.Length);
		foreach (MonsterInGroupInformations item in this.Underlings)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MainCreatureLightInfos = new MonsterInGroupLightInformations();
		this.MainCreatureLightInfos.Deserialize(reader);
		int UnderlingsLen = reader.ReadShort();
		Underlings = new MonsterInGroupInformations[UnderlingsLen];
		for (int i = 0; i < UnderlingsLen; i++)
		{
			this.Underlings[i] = new MonsterInGroupInformations();
			this.Underlings[i].Deserialize(reader);
		}
	}
}
}
