using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeBidHouseItemRemoveOkMessage : NetworkMessage
{

	public const uint Id = 5946;
	public override uint MessageId { get { return Id; } }

	public int SellerId { get; set; }

	public ExchangeBidHouseItemRemoveOkMessage() {}


	public ExchangeBidHouseItemRemoveOkMessage InitExchangeBidHouseItemRemoveOkMessage(int SellerId)
	{
		this.SellerId = SellerId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.SellerId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SellerId = reader.ReadInt();
	}
}
}
