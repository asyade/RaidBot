using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class StatisticDataInt : StatisticData
{

	public const uint Id = 485;
	public override uint MessageId { get { return Id; } }

	public int Value { get; set; }

	public StatisticDataInt() {}


	public StatisticDataInt InitStatisticDataInt(int Value)
	{
		this.Value = Value;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteInt(this.Value);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Value = reader.ReadInt();
	}
}
}
