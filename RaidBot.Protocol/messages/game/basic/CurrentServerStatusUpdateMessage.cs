using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class CurrentServerStatusUpdateMessage : NetworkMessage
{

	public const uint Id = 6525;
	public override uint MessageId { get { return Id; } }

	public byte Status { get; set; }

	public CurrentServerStatusUpdateMessage() {}


	public CurrentServerStatusUpdateMessage InitCurrentServerStatusUpdateMessage(byte Status)
	{
		this.Status = Status;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Status);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Status = reader.ReadByte();
	}
}
}
