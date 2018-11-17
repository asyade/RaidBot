using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class StatisticDataBoolean : StatisticData
{

	public const uint Id = 482;
	public override uint MessageId { get { return Id; } }

	public bool Value { get; set; }

	public StatisticDataBoolean() {}


	public StatisticDataBoolean InitStatisticDataBoolean(bool Value)
	{
		this.Value = Value;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteBoolean(this.Value);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Value = reader.ReadBoolean();
	}
}
}
