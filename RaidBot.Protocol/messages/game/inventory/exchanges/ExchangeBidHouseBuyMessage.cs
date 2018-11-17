using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeBidHouseBuyMessage : NetworkMessage
{

	public const uint Id = 5804;
	public override uint MessageId { get { return Id; } }

	public int Uid { get; set; }
	public int Qty { get; set; }
	public long Price { get; set; }

	public ExchangeBidHouseBuyMessage() {}


	public ExchangeBidHouseBuyMessage InitExchangeBidHouseBuyMessage(int Uid, int Qty, long Price)
	{
		this.Uid = Uid;
		this.Qty = Qty;
		this.Price = Price;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.Uid);
		writer.WriteVarInt(this.Qty);
		writer.WriteVarLong(this.Price);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Uid = reader.ReadVarInt();
		this.Qty = reader.ReadVarInt();
		this.Price = reader.ReadVarLong();
	}
}
}
