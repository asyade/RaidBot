using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class StatisticDataString : StatisticData
{

	public const uint Id = 487;
	public override uint MessageId { get { return Id; } }

	public String Value { get; set; }

	public StatisticDataString() {}


	public StatisticDataString InitStatisticDataString(String Value)
	{
		this.Value = Value;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteUTF(this.Value);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Value = reader.ReadUTF();
	}
}
}
