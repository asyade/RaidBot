using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightPointsVariationMessage : AbstractGameActionMessage
{

	public const uint Id = 1030;
	public override uint MessageId { get { return Id; } }

	public double TargetId { get; set; }
	public short Delta { get; set; }

	public GameActionFightPointsVariationMessage() {}


	public GameActionFightPointsVariationMessage InitGameActionFightPointsVariationMessage(double TargetId, short Delta)
	{
		this.TargetId = TargetId;
		this.Delta = Delta;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.TargetId);
		writer.WriteShort(this.Delta);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.TargetId = reader.ReadDouble();
		this.Delta = reader.ReadShort();
	}
}
}
