using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayNpcWithQuestInformations : GameRolePlayNpcInformations
{

	public const uint Id = 383;
	public override uint MessageId { get { return Id; } }

	public GameRolePlayNpcQuestFlag QuestFlag { get; set; }

	public GameRolePlayNpcWithQuestInformations() {}


	public GameRolePlayNpcWithQuestInformations InitGameRolePlayNpcWithQuestInformations(GameRolePlayNpcQuestFlag QuestFlag)
	{
		this.QuestFlag = QuestFlag;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		this.QuestFlag.Serialize(writer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.QuestFlag = new GameRolePlayNpcQuestFlag();
		this.QuestFlag.Deserialize(reader);
	}
}
}
