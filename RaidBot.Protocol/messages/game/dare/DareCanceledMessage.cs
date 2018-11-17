using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DareCanceledMessage : NetworkMessage
{

	public const uint Id = 6679;
	public override uint MessageId { get { return Id; } }

	public double DareId { get; set; }

	public DareCanceledMessage() {}


	public DareCanceledMessage InitDareCanceledMessage(double DareId)
	{
		this.DareId = DareId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.DareId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.DareId = reader.ReadDouble();
	}
}
}
