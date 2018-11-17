using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class QueueStatusMessage : NetworkMessage
{

	public const uint Id = 6100;
	public override uint MessageId { get { return Id; } }

	public short Position { get; set; }
	public short Total { get; set; }

	public QueueStatusMessage() {}


	public QueueStatusMessage InitQueueStatusMessage(short Position, short Total)
	{
		this.Position = Position;
		this.Total = Total;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Position);
		writer.WriteShort(this.Total);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Position = reader.ReadShort();
		this.Total = reader.ReadShort();
	}
}
}
