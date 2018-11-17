using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStartOkRecycleTradeMessage : NetworkMessage
{

	public const uint Id = 6600;
	public override uint MessageId { get { return Id; } }

	public short PercentToPrism { get; set; }
	public short PercentToPlayer { get; set; }

	public ExchangeStartOkRecycleTradeMessage() {}


	public ExchangeStartOkRecycleTradeMessage InitExchangeStartOkRecycleTradeMessage(short PercentToPrism, short PercentToPlayer)
	{
		this.PercentToPrism = PercentToPrism;
		this.PercentToPlayer = PercentToPlayer;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteShort(this.PercentToPrism);
		writer.WriteShort(this.PercentToPlayer);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PercentToPrism = reader.ReadShort();
		this.PercentToPlayer = reader.ReadShort();
	}
}
}
