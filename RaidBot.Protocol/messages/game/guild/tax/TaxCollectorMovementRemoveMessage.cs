using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class TaxCollectorMovementRemoveMessage : NetworkMessage
{

	public const uint Id = 5915;
	public override uint MessageId { get { return Id; } }

	public double CollectorId { get; set; }

	public TaxCollectorMovementRemoveMessage() {}


	public TaxCollectorMovementRemoveMessage InitTaxCollectorMovementRemoveMessage(double CollectorId)
	{
		this.CollectorId = CollectorId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.CollectorId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.CollectorId = reader.ReadDouble();
	}
}
}
