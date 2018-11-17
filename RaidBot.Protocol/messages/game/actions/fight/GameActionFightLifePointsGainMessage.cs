using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightLifePointsGainMessage : AbstractGameActionMessage
{

	public const uint Id = 6311;
	public override uint MessageId { get { return Id; } }

	public double TargetId { get; set; }
	public int Delta { get; set; }

	public GameActionFightLifePointsGainMessage() {}


	public GameActionFightLifePointsGainMessage InitGameActionFightLifePointsGainMessage(double TargetId, int Delta)
	{
		this.TargetId = TargetId;
		this.Delta = Delta;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.TargetId);
		writer.WriteVarInt(this.Delta);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.TargetId = reader.ReadDouble();
		this.Delta = reader.ReadVarInt();
	}
}
}
