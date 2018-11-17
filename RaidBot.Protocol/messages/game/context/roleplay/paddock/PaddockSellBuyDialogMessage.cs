using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PaddockSellBuyDialogMessage : NetworkMessage
{

	public const uint Id = 6018;
	public override uint MessageId { get { return Id; } }

	public bool Bsell { get; set; }
	public int OwnerId { get; set; }
	public long Price { get; set; }

	public PaddockSellBuyDialogMessage() {}


	public PaddockSellBuyDialogMessage InitPaddockSellBuyDialogMessage(bool Bsell, int OwnerId, long Price)
	{
		this.Bsell = Bsell;
		this.OwnerId = OwnerId;
		this.Price = Price;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteBoolean(this.Bsell);
		writer.WriteVarInt(this.OwnerId);
		writer.WriteVarLong(this.Price);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.Bsell = reader.ReadBoolean();
		this.OwnerId = reader.ReadVarInt();
		this.Price = reader.ReadVarLong();
	}
}
}
