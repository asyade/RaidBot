


















// Generated on 06/26/2015 11:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStartedBidBuyerMessage : NetworkMessage
{

public const uint Id = 5904;
public override uint MessageId
{
    get { return Id; }
}

public Types.SellerBuyerDescriptor buyerDescriptor;
        

public ExchangeStartedBidBuyerMessage()
{
}

public ExchangeStartedBidBuyerMessage(Types.SellerBuyerDescriptor buyerDescriptor)
        {
            this.buyerDescriptor = buyerDescriptor;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

buyerDescriptor.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

buyerDescriptor = new Types.SellerBuyerDescriptor();
            buyerDescriptor.Deserialize(reader);
            

}


}


}