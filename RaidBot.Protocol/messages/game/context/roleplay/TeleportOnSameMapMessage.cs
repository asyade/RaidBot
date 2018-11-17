using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TeleportOnSameMapMessage : NetworkMessage
{

	public const uint Id = 6048;
	public override uint MessageId { get { return Id; } }

	public double TargetId { get; set; }
	public short CellId { get; set; }

	public TeleportOnSameMapMessage() {}


	public TeleportOnSameMapMessage InitTeleportOnSameMapMessage(double TargetId, short CellId)
	{
		this.TargetId = TargetId;
		this.CellId = CellId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.TargetId);
		writer.WriteVarShort(this.CellId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.TargetId = reader.ReadDouble();
		this.CellId = reader.ReadVarShort();
	}
}
}
