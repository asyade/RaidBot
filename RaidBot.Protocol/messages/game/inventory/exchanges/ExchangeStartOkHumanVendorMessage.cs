using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStartOkHumanVendorMessage : NetworkMessage
{

	public const uint Id = 5767;
	public override uint MessageId { get { return Id; } }

	public double SellerId { get; set; }
	public ObjectItemToSellInHumanVendorShop[] ObjectsInfos { get; set; }

	public ExchangeStartOkHumanVendorMessage() {}


	public ExchangeStartOkHumanVendorMessage InitExchangeStartOkHumanVendorMessage(double SellerId, ObjectItemToSellInHumanVendorShop[] ObjectsInfos)
	{
		this.SellerId = SellerId;
		this.ObjectsInfos = ObjectsInfos;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		writer.WriteDouble(this.SellerId);
		writer.WriteShort(this.ObjectsInfos.Length);
		foreach (ObjectItemToSellInHumanVendorShop item in this.ObjectsInfos)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SellerId = reader.ReadDouble();
		int ObjectsInfosLen = reader.ReadShort();
		ObjectsInfos = new ObjectItemToSellInHumanVendorShop[ObjectsInfosLen];
		for (int i = 0; i < ObjectsInfosLen; i++)
		{
			this.ObjectsInfos[i] = new ObjectItemToSellInHumanVendorShop();
			this.ObjectsInfos[i].Deserialize(reader);
		}
	}
}
}
