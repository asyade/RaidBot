using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeObjectUseInWorkshopMessage : NetworkMessage
{

	public const uint Id = 6004;
	public override uint MessageId { get { return Id; } }

	public int ObjectUID { get; set; }
	public int Quantity { get; set; }

	public ExchangeObjectUseInWorkshopMessage() {}


	public ExchangeObjectUseInWorkshopMessage InitExchangeObjectUseInWorkshopMessage(int ObjectUID, int Quantity)
	{
		this.ObjectUID = ObjectUID;
		this.Quantity = Quantity;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteVarInt(this.ObjectUID);
		writer.WriteVarInt(this.Quantity);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.ObjectUID = reader.ReadVarInt();
		this.Quantity = reader.ReadVarInt();
	}
}
}
