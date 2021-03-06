using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ServerSessionConstantLong : ServerSessionConstant
{

	public const uint Id = 429;
	public override uint MessageId { get { return Id; } }

	public double Value { get; set; }

	public ServerSessionConstantLong() {}


	public ServerSessionConstantLong InitServerSessionConstantLong(double Value)
	{
		this.Value = Value;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		base.Serialize(writer);
		writer.WriteDouble(this.Value);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		base.Deserialize(reader);
		this.Value = reader.ReadDouble();
	}
}
}
