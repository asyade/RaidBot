using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeRequestMessage : NetworkMessage
{

	public const uint Id = 5505;
	public override uint MessageId { get { return Id; } }

	public byte ExchangeType { get; set; }

	public ExchangeRequestMessage() {}


	public ExchangeRequestMessage InitExchangeRequestMessage(byte ExchangeType)
	{
		this.ExchangeType = ExchangeType;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteByte(this.ExchangeType);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ExchangeType = reader.ReadByte();
	}
}
}
