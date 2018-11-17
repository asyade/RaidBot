using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeObjectMoveKamaMessage : NetworkMessage
{

	public const uint Id = 5520;
	public override uint MessageId { get { return Id; } }

	public long Quantity { get; set; }

	public ExchangeObjectMoveKamaMessage() {}


	public ExchangeObjectMoveKamaMessage InitExchangeObjectMoveKamaMessage(long Quantity)
	{
		this.Quantity = Quantity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarLong(this.Quantity);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Quantity = reader.ReadVarLong();
	}
}
}
