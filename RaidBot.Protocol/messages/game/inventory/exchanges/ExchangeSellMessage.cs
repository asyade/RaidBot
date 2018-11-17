using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeSellMessage : NetworkMessage
{

	public const uint Id = 5778;
	public override uint MessageId { get { return Id; } }

	public int ObjectToSellId { get; set; }
	public int Quantity { get; set; }

	public ExchangeSellMessage() {}


	public ExchangeSellMessage InitExchangeSellMessage(int ObjectToSellId, int Quantity)
	{
		this.ObjectToSellId = ObjectToSellId;
		this.Quantity = Quantity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.ObjectToSellId);
		writer.WriteVarInt(this.Quantity);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObjectToSellId = reader.ReadVarInt();
		this.Quantity = reader.ReadVarInt();
	}
}
}
