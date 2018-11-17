using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeBidHouseTypeMessage : NetworkMessage
{

	public const uint Id = 5803;
	public override uint MessageId { get { return Id; } }

	public int Type { get; set; }

	public ExchangeBidHouseTypeMessage() {}


	public ExchangeBidHouseTypeMessage InitExchangeBidHouseTypeMessage(int Type)
	{
		this.Type = Type;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.Type);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Type = reader.ReadVarInt();
	}
}
}
