using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameFightJoinRequestMessage : NetworkMessage
{

	public const uint Id = 701;
	public override uint MessageId { get { return Id; } }

	public double FighterId { get; set; }
	public short FightId { get; set; }

	public GameFightJoinRequestMessage() {}


	public GameFightJoinRequestMessage InitGameFightJoinRequestMessage(double FighterId, short FightId)
	{
		this.FighterId = FighterId;
		this.FightId = FightId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.FighterId);
		writer.WriteVarShort(this.FightId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.FighterId = reader.ReadDouble();
		this.FightId = reader.ReadVarShort();
	}
}
}
