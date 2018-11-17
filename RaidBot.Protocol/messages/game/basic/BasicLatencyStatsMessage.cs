using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class BasicLatencyStatsMessage : NetworkMessage
{

	public const uint Id = 5663;
	public override uint MessageId { get { return Id; } }

	public short Latency { get; set; }
	public short SampleCount { get; set; }
	public short Max { get; set; }

	public BasicLatencyStatsMessage() {}


	public BasicLatencyStatsMessage InitBasicLatencyStatsMessage(short Latency, short SampleCount, short Max)
	{
		this.Latency = Latency;
		this.SampleCount = SampleCount;
		this.Max = Max;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.Latency);
		writer.WriteVarShort(this.SampleCount);
		writer.WriteVarShort(this.Max);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Latency = reader.ReadShort();
		this.SampleCount = reader.ReadVarShort();
		this.Max = reader.ReadVarShort();
	}
}
}
