using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class DareCancelRequestMessage : NetworkMessage
{

	public const uint Id = 6680;
	public override uint MessageId { get { return Id; } }

	public double DareId { get; set; }

	public DareCancelRequestMessage() {}


	public DareCancelRequestMessage InitDareCancelRequestMessage(double DareId)
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
