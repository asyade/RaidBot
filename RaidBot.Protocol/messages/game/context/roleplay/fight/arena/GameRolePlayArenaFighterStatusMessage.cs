using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameRolePlayArenaFighterStatusMessage : NetworkMessage
{

	public const uint Id = 6281;
	public override uint MessageId { get { return Id; } }

	public short FightId { get; set; }
	public double PlayerId { get; set; }
	public bool Accepted { get; set; }

	public GameRolePlayArenaFighterStatusMessage() {}


	public GameRolePlayArenaFighterStatusMessage InitGameRolePlayArenaFighterStatusMessage(short FightId, double PlayerId, bool Accepted)
	{
		this.FightId = FightId;
		this.PlayerId = PlayerId;
		this.Accepted = Accepted;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.FightId);
		writer.WriteDouble(this.PlayerId);
		writer.WriteBoolean(this.Accepted);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightId = reader.ReadVarShort();
		this.PlayerId = reader.ReadDouble();
		this.Accepted = reader.ReadBoolean();
	}
}
}
