using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayMonsterNotAngryAtPlayerMessage : NetworkMessage
{

	public const uint Id = 6742;
	public override uint MessageId { get { return Id; } }

	public long PlayerId { get; set; }
	public double MonsterGroupId { get; set; }

	public GameRolePlayMonsterNotAngryAtPlayerMessage() {}


	public GameRolePlayMonsterNotAngryAtPlayerMessage InitGameRolePlayMonsterNotAngryAtPlayerMessage(long PlayerId, double MonsterGroupId)
	{
		this.PlayerId = PlayerId;
		this.MonsterGroupId = MonsterGroupId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.PlayerId);
		writer.WriteDouble(this.MonsterGroupId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PlayerId = reader.ReadVarLong();
		this.MonsterGroupId = reader.ReadDouble();
	}
}
}
