using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class GameActionFightTeleportOnSameMapMessage : AbstractGameActionMessage
{

	public const uint Id = 5528;
	public override uint MessageId { get { return Id; } }

	public double TargetId { get; set; }
	public short CellId { get; set; }

	public GameActionFightTeleportOnSameMapMessage() {}


	public GameActionFightTeleportOnSameMapMessage InitGameActionFightTeleportOnSameMapMessage(double TargetId, short CellId)
	{
		this.TargetId = TargetId;
		this.CellId = CellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.TargetId);
		writer.WriteShort(this.CellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.TargetId = reader.ReadDouble();
		this.CellId = reader.ReadShort();
	}
}
}
