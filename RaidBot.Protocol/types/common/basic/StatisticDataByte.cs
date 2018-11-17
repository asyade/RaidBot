using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class StatisticDataByte : StatisticData
{

	public const uint Id = 486;
	public override uint MessageId { get { return Id; } }

	public byte Value { get; set; }

	public StatisticDataByte() {}


	public StatisticDataByte InitStatisticDataByte(byte Value)
	{
		this.Value = Value;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteByte(this.Value);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Value = reader.ReadByte();
	}
}
}
