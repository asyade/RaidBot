using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeBuyMessage : NetworkMessage
{

	public const uint Id = 5774;
	public override uint MessageId { get { return Id; } }

	public int ObjectToBuyId { get; set; }
	public int Quantity { get; set; }

	public ExchangeBuyMessage() {}


	public ExchangeBuyMessage InitExchangeBuyMessage(int ObjectToBuyId, int Quantity)
	{
		this.ObjectToBuyId = ObjectToBuyId;
		this.Quantity = Quantity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.ObjectToBuyId);
		writer.WriteVarInt(this.Quantity);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObjectToBuyId = reader.ReadVarInt();
		this.Quantity = reader.ReadVarInt();
	}
}
}
