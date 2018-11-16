


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeTypesExchangerDescriptionForUserMessage : NetworkMessage
{

public const uint Id = 5765;
public override uint MessageId
{
    get { return Id; }
}

public uint[] typeDescription;
        

public ExchangeTypesExchangerDescriptionForUserMessage()
{
}

public ExchangeTypesExchangerDescriptionForUserMessage(uint[] typeDescription)
        {
            this.typeDescription = typeDescription;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)typeDescription.Length);
            foreach (var entry in typeDescription)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            typeDescription = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 typeDescription[i] = reader.ReadVaruhint();
            }
            

}


}


}