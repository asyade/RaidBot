


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AbstractTaxCollectorListMessage : NetworkMessage
{

public const uint Id = 6568;
public override uint MessageId
{
    get { return Id; }
}

public Types.TaxCollectorInformations[] informations;
        

public AbstractTaxCollectorListMessage()
{
}

public AbstractTaxCollectorListMessage(Types.TaxCollectorInformations[] informations)
        {
            this.informations = informations;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)informations.Length);
            foreach (var entry in informations)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            informations = new Types.TaxCollectorInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 informations[i] = Types.ProtocolTypeManager.GetInstance<Types.TaxCollectorInformations>(reader.ReadShort());
                 informations[i].Deserialize(reader);
            }
            

}


}


}