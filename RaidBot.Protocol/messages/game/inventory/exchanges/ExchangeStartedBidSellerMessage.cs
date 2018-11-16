


















// Generated on 06/26/2015 11:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStartedBidSellerMessage : NetworkMessage
{

public const uint Id = 5905;
public override uint MessageId
{
    get { return Id; }
}

public Types.SellerBuyerDescriptor sellerDescriptor;
        public Types.ObjectItemToSellInBid[] objectsInfos;
        

public ExchangeStartedBidSellerMessage()
{
}

public ExchangeStartedBidSellerMessage(Types.SellerBuyerDescriptor sellerDescriptor, Types.ObjectItemToSellInBid[] objectsInfos)
        {
            this.sellerDescriptor = sellerDescriptor;
            this.objectsInfos = objectsInfos;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

sellerDescriptor.Serialize(writer);
            writer.WriteUShort((ushort)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

sellerDescriptor = new Types.SellerBuyerDescriptor();
            sellerDescriptor.Deserialize(reader);
            var limit = reader.ReadUShort();
            objectsInfos = new Types.ObjectItemToSellInBid[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItemToSellInBid();
                 objectsInfos[i].Deserialize(reader);
            }
            

}


}


}