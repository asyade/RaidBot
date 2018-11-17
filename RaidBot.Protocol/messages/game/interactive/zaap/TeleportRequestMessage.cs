using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TeleportRequestMessage : NetworkMessage
{

	public const uint Id = 5961;
	public override uint MessageId { get { return Id; } }

	public byte TeleporterType { get; set; }
	public double MapId { get; set; }

	public TeleportRequestMessage() {}


	public TeleportRequestMessage InitTeleportRequestMessage(byte TeleporterType, double MapId)
	{
		this.TeleporterType = TeleporterType;
		this.MapId = MapId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.TeleporterType);
		writer.WriteDouble(this.MapId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.TeleporterType = reader.ReadByte();
		this.MapId = reader.ReadDouble();
	}
}
}
