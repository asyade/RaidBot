using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorStateUpdateMessage : NetworkMessage
{

	public const uint Id = 6455;
	public override uint MessageId { get { return Id; } }

	public double UniqueId { get; set; }
	public byte State { get; set; }

	public TaxCollectorStateUpdateMessage() {}


	public TaxCollectorStateUpdateMessage InitTaxCollectorStateUpdateMessage(double UniqueId, byte State)
	{
		this.UniqueId = UniqueId;
		this.State = State;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.UniqueId);
		writer.WriteByte(this.State);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.UniqueId = reader.ReadDouble();
		this.State = reader.ReadByte();
	}
}
}
