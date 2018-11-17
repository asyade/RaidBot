using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayAggressionMessage : NetworkMessage
{

	public const uint Id = 6073;
	public override uint MessageId { get { return Id; } }

	public long AttackerId { get; set; }
	public long DefenderId { get; set; }

	public GameRolePlayAggressionMessage() {}


	public GameRolePlayAggressionMessage InitGameRolePlayAggressionMessage(long AttackerId, long DefenderId)
	{
		this.AttackerId = AttackerId;
		this.DefenderId = DefenderId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.AttackerId);
		writer.WriteVarLong(this.DefenderId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.AttackerId = reader.ReadVarLong();
		this.DefenderId = reader.ReadVarLong();
	}
}
}
