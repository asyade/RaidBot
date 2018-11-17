using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightStartingMessage : NetworkMessage
{

	public const uint Id = 700;
	public override uint MessageId { get { return Id; } }

	public byte FightType { get; set; }
	public short FightId { get; set; }
	public double AttackerId { get; set; }
	public double DefenderId { get; set; }

	public GameFightStartingMessage() {}


	public GameFightStartingMessage InitGameFightStartingMessage(byte FightType, short FightId, double AttackerId, double DefenderId)
	{
		this.FightType = FightType;
		this.FightId = FightId;
		this.AttackerId = AttackerId;
		this.DefenderId = DefenderId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.FightType);
		writer.WriteVarShort(this.FightId);
		writer.WriteDouble(this.AttackerId);
		writer.WriteDouble(this.DefenderId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FightType = reader.ReadByte();
		this.FightId = reader.ReadVarShort();
		this.AttackerId = reader.ReadDouble();
		this.DefenderId = reader.ReadDouble();
	}
}
}
