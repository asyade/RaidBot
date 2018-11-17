using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class BasicTimeMessage : NetworkMessage
{

	public const uint Id = 175;
	public override uint MessageId { get { return Id; } }

	public double Timestamp { get; set; }
	public short TimezoneOffset { get; set; }

	public BasicTimeMessage() {}


	public BasicTimeMessage InitBasicTimeMessage(double Timestamp, short TimezoneOffset)
	{
		this.Timestamp = Timestamp;
		this.TimezoneOffset = TimezoneOffset;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.Timestamp);
		writer.WriteShort(this.TimezoneOffset);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Timestamp = reader.ReadDouble();
		this.TimezoneOffset = reader.ReadShort();
	}
}
}
