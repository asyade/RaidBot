


















// Generated on 06/26/2015 11:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidPriceForSellerMessage : ExchangeBidPriceMessage
{

public const uint Id = 6464;
public override uint MessageId
{
    get { return Id; }
}

public bool allIdentical;
        public uint[] minimalPrices;
        

public ExchangeBidPriceForSellerMessage()
{
}

public ExchangeBidPriceForSellerMessage(ushort genericId, int averagePrice, bool allIdentical, uint[] minimalPrices)
         : base(genericId, averagePrice)
        {
            this.allIdentical = allIdentical;
            this.minimalPrices = minimalPrices;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(allIdentical);
            writer.WriteUShort((ushort)minimalPrices.Length);
            foreach (var entry in minimalPrices)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            allIdentical = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            minimalPrices = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 minimalPrices[i] = reader.ReadVaruhint();
            }
            

}


}


}