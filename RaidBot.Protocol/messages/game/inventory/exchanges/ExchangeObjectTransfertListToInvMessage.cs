


















// Generated on 06/26/2015 11:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeObjectTransfertListToInvMessage : NetworkMessage
{

public const uint Id = 6039;
public override uint MessageId
{
    get { return Id; }
}

public uint[] ids;
        

public ExchangeObjectTransfertListToInvMessage()
{
}

public ExchangeObjectTransfertListToInvMessage(uint[] ids)
        {
            this.ids = ids;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            ids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadVaruhint();
            }
            

}


}


}