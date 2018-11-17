using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Protocol.Messages;
using RaidBot.Common.IO;

namespace Raidbot.Protocol.Messages
{
public class ExchangeStartedBidSellerMessage : NetworkMessage
{

	public const uint Id = 5905;
	public override uint MessageId { get { return Id; } }

	public SellerBuyerDescriptor SellerDescriptor { get; set; }
	public ObjectItemToSellInBid[] ObjectsInfos { get; set; }

	public ExchangeStartedBidSellerMessage() {}


	public ExchangeStartedBidSellerMessage InitExchangeStartedBidSellerMessage(SellerBuyerDescriptor SellerDescriptor, ObjectItemToSellInBid[] ObjectsInfos)
	{
		this.SellerDescriptor = SellerDescriptor;
		this.ObjectsInfos = ObjectsInfos;
		return (this);
	}

	public override void Serialize(ICustomDataWriter writer)
	{
		this.SellerDescriptor.Serialize(writer);
		writer.WriteShort(this.ObjectsInfos.Length);
		foreach (ObjectItemToSellInBid item in this.ObjectsInfos)
		{
			item.Serialize(writer);
		}
	}

	public override void Deserialize(ICustomDataReader reader)
	{
		this.SellerDescriptor = new SellerBuyerDescriptor();
		this.SellerDescriptor.Deserialize(reader);
		int ObjectsInfosLen = reader.ReadShort();
		ObjectsInfos = new ObjectItemToSellInBid[ObjectsInfosLen];
		for (int i = 0; i < ObjectsInfosLen; i++)
		{
			this.ObjectsInfos[i] = new ObjectItemToSellInBid();
			this.ObjectsInfos[i].Deserialize(reader);
		}
	}
}
}
