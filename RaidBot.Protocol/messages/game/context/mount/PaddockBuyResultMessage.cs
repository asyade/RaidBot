using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class PaddockBuyResultMessage : NetworkMessage
{

	public const uint Id = 6516;
	public override uint MessageId { get { return Id; } }

	public double PaddockId { get; set; }
	public bool Bought { get; set; }
	public long RealPrice { get; set; }

	public PaddockBuyResultMessage() {}


	public PaddockBuyResultMessage InitPaddockBuyResultMessage(double PaddockId, bool Bought, long RealPrice)
	{
		this.PaddockId = PaddockId;
		this.Bought = Bought;
		this.RealPrice = RealPrice;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.PaddockId);
		writer.WriteBoolean(this.Bought);
		writer.WriteVarLong(this.RealPrice);
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.PaddockId = reader.ReadDouble();
		this.Bought = reader.ReadBoolean();
		this.RealPrice = reader.ReadVarLong();
	}
}
}
