using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayAttackMonsterRequestMessage : NetworkMessage
{

	public const uint Id = 6191;
	public override uint MessageId { get { return Id; } }

	public double MonsterGroupId { get; set; }

	public GameRolePlayAttackMonsterRequestMessage() {}


	public GameRolePlayAttackMonsterRequestMessage InitGameRolePlayAttackMonsterRequestMessage(double MonsterGroupId)
	{
		this.MonsterGroupId = MonsterGroupId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.MonsterGroupId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.MonsterGroupId = reader.ReadDouble();
	}
}
}
