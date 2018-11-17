using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeBidHouseInListRemovedMessage : NetworkMessage
{

	public const uint Id = 5950;
	public override uint MessageId { get { return Id; } }

	public int ItemUID { get; set; }

	public ExchangeBidHouseInListRemovedMessage() {}


	public ExchangeBidHouseInListRemovedMessage InitExchangeBidHouseInListRemovedMessage(int ItemUID)
	{
		this.ItemUID = ItemUID;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteInt(this.ItemUID);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ItemUID = reader.ReadInt();
	}
}
}
