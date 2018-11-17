using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PrismFightersInformation : NetworkType
{

	public const uint Id = 443;
	public override uint MessageId { get { return Id; } }

	public short SubAreaId { get; set; }
	public ProtectedEntityWaitingForHelpInfo WaitingForHelpInfo { get; set; }
	public CharacterMinimalPlusLookInformations[] AllyCharactersInformations { get; set; }
	public CharacterMinimalPlusLookInformations[] EnemyCharactersInformations { get; set; }

	public PrismFightersInformation() {}


	public PrismFightersInformation InitPrismFightersInformation(short SubAreaId, ProtectedEntityWaitingForHelpInfo WaitingForHelpInfo, CharacterMinimalPlusLookInformations[] AllyCharactersInformations, CharacterMinimalPlusLookInformations[] EnemyCharactersInformations)
	{
		this.SubAreaId = SubAreaId;
		this.WaitingForHelpInfo = WaitingForHelpInfo;
		this.AllyCharactersInformations = AllyCharactersInformations;
		this.EnemyCharactersInformations = EnemyCharactersInformations;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.SubAreaId);
		this.WaitingForHelpInfo.Serialize(writer);
		writer.WriteShort(this.AllyCharactersInformations.Length);
		foreach (CharacterMinimalPlusLookInformations item in this.AllyCharactersInformations)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
		writer.WriteShort(this.EnemyCharactersInformations.Length);
		foreach (CharacterMinimalPlusLookInformations item in this.EnemyCharactersInformations)
		{
			writer.WriteShort(item.MessageId);
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SubAreaId = reader.ReadVarShort();
		this.WaitingForHelpInfo = new ProtectedEntityWaitingForHelpInfo();
		this.WaitingForHelpInfo.Deserialize(reader);
		int AllyCharactersInformationsLen = reader.ReadShort();
		AllyCharactersInformations = new CharacterMinimalPlusLookInformations[AllyCharactersInformationsLen];
		for (int i = 0; i < AllyCharactersInformationsLen; i++)
		{
			this.AllyCharactersInformations[i] = ProtocolTypeManager.GetInstance<CharacterMinimalPlusLookInformations>(reader.ReadShort());
			this.AllyCharactersInformations[i].Deserialize(reader);
		}
		int EnemyCharactersInformationsLen = reader.ReadShort();
		EnemyCharactersInformations = new CharacterMinimalPlusLookInformations[EnemyCharactersInformationsLen];
		for (int i = 0; i < EnemyCharactersInformationsLen; i++)
		{
			this.EnemyCharactersInformations[i] = ProtocolTypeManager.GetInstance<CharacterMinimalPlusLookInformations>(reader.ReadShort());
			this.EnemyCharactersInformations[i].Deserialize(reader);
		}
	}
}
}
