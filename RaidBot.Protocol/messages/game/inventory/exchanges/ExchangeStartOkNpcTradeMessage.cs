using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStartOkNpcTradeMessage : NetworkMessage
{

	public const uint Id = 5785;
	public override uint MessageId { get { return Id; } }

	public double NpcId { get; set; }

	public ExchangeStartOkNpcTradeMessage() {}


	public ExchangeStartOkNpcTradeMessage InitExchangeStartOkNpcTradeMessage(double NpcId)
	{
		this.NpcId = NpcId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.NpcId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.NpcId = reader.ReadDouble();
	}
}
}
