using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class StatisticDataShort : StatisticData
{

	public const uint Id = 488;
	public override uint MessageId { get { return Id; } }

	public short Value { get; set; }

	public StatisticDataShort() {}


	public StatisticDataShort InitStatisticDataShort(short Value)
	{
		this.Value = Value;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteShort(this.Value);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Value = reader.ReadShort();
	}
}
}
