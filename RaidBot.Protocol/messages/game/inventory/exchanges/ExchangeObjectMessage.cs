using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeObjectMessage : NetworkMessage
{

	public const uint Id = 5515;
	public override uint MessageId { get { return Id; } }

	public bool Remote { get; set; }

	public ExchangeObjectMessage() {}


	public ExchangeObjectMessage InitExchangeObjectMessage(bool Remote)
	{
		this.Remote = Remote;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Remote);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Remote = reader.ReadBoolean();
	}
}
}
