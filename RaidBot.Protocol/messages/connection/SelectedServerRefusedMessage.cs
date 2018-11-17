using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class SelectedServerRefusedMessage : NetworkMessage
{

	public const uint Id = 41;
	public override uint MessageId { get { return Id; } }

	public short ServerId { get; set; }
	public byte Error { get; set; }
	public byte ServerStatus { get; set; }

	public SelectedServerRefusedMessage() {}


	public SelectedServerRefusedMessage InitSelectedServerRefusedMessage(short ServerId, byte Error, byte ServerStatus)
	{
		this.ServerId = ServerId;
		this.Error = Error;
		this.ServerStatus = ServerStatus;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.ServerId);
		writer.WriteByte(this.Error);
		writer.WriteByte(this.ServerStatus);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ServerId = reader.ReadVarShort();
		this.Error = reader.ReadByte();
		this.ServerStatus = reader.ReadByte();
	}
}
}
