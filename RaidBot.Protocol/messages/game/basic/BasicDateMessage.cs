using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class BasicDateMessage : NetworkMessage
{

	public const uint Id = 177;
	public override uint MessageId { get { return Id; } }

	public byte Day { get; set; }
	public byte Month { get; set; }
	public short Year { get; set; }

	public BasicDateMessage() {}


	public BasicDateMessage InitBasicDateMessage(byte Day, byte Month, short Year)
	{
		this.Day = Day;
		this.Month = Month;
		this.Year = Year;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.Day);
		writer.WriteByte(this.Month);
		writer.WriteShort(this.Year);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Day = reader.ReadByte();
		this.Month = reader.ReadByte();
		this.Year = reader.ReadShort();
	}
}
}
