using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeShopStockMovementRemovedMessage : NetworkMessage
{

	public const uint Id = 5907;
	public override uint MessageId { get { return Id; } }

	public int ObjectId { get; set; }

	public ExchangeShopStockMovementRemovedMessage() {}


	public ExchangeShopStockMovementRemovedMessage InitExchangeShopStockMovementRemovedMessage(int ObjectId)
	{
		this.ObjectId = ObjectId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.ObjectId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObjectId = reader.ReadVarInt();
	}
}
}
