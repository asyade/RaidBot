using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightDeathMessage : AbstractGameActionMessage
{

	public const uint Id = 1099;
	public override uint MessageId { get { return Id; } }

	public double TargetId { get; set; }

	public GameActionFightDeathMessage() {}


	public GameActionFightDeathMessage InitGameActionFightDeathMessage(double TargetId)
	{
		this.TargetId = TargetId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.TargetId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.TargetId = reader.ReadDouble();
	}
}
}
