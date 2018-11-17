using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GuildFightPlayersEnemyRemoveMessage : NetworkMessage
{

	public const uint Id = 5929;
	public override uint MessageId { get { return Id; } }

	public double FightId { get; set; }
	public long PlayerId { get; set; }

	public GuildFightPlayersEnemyRemoveMessage() {}


	public GuildFightPlayersEnemyRemoveMessage InitGuildFightPlayersEnemyRemoveMessage(double FightId, long PlayerId)
	{
		this.FightId = FightId;
		this.PlayerId = PlayerId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.FightId);
		writer.WriteVarLong(this.PlayerId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightId = reader.ReadDouble();
		this.PlayerId = reader.ReadVarLong();
	}
}
}
