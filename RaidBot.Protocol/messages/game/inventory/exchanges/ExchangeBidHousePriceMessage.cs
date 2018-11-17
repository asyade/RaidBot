using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeBidHousePriceMessage : NetworkMessage
{

	public const uint Id = 5805;
	public override uint MessageId { get { return Id; } }

	public short GenId { get; set; }

	public ExchangeBidHousePriceMessage() {}


	public ExchangeBidHousePriceMessage InitExchangeBidHousePriceMessage(short GenId)
	{
		this.GenId = GenId;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarShort(this.GenId);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.GenId = reader.ReadVarShort();
	}
}
}
