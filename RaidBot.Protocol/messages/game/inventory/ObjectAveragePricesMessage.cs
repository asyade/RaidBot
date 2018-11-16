


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectAveragePricesMessage : NetworkMessage
{

public const uint Id = 6335;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] ids;
        public uint[] avgPrices;
        

public ObjectAveragePricesMessage()
{
}

public ObjectAveragePricesMessage(ushort[] ids, uint[] avgPrices)
        {
            this.ids = ids;
            this.avgPrices = avgPrices;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)avgPrices.Length);
            foreach (var entry in avgPrices)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            ids = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            avgPrices = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 avgPrices[i] = reader.ReadVaruhint();
            }
            

}


}


}