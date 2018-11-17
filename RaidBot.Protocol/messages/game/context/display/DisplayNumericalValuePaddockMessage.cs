using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DisplayNumericalValuePaddockMessage : NetworkMessage
{

	public const uint Id = 6563;
	public override uint MessageId { get { return Id; } }

	public int RideId { get; set; }
	public int Value { get; set; }
	public byte Type { get; set; }

	public DisplayNumericalValuePaddockMessage() {}


	public DisplayNumericalValuePaddockMessage InitDisplayNumericalValuePaddockMessage(int RideId, int Value, byte Type)
	{
		this.RideId = RideId;
		this.Value = Value;
		this.Type = Type;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.RideId);
		writer.WriteInt(this.Value);
		writer.WriteByte(this.Type);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.RideId = reader.ReadInt();
		this.Value = reader.ReadInt();
		this.Type = reader.ReadByte();
	}
}
}
