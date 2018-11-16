


















// Generated on 06/26/2015 11:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeObjectTransfertListWithQuantityToInvMessage : NetworkMessage
{

public const uint Id = 6470;
public override uint MessageId
{
    get { return Id; }
}

public uint[] ids;
        public uint[] qtys;
        

public ExchangeObjectTransfertListWithQuantityToInvMessage()
{
}

public ExchangeObjectTransfertListWithQuantityToInvMessage(uint[] ids, uint[] qtys)
        {
            this.ids = ids;
            this.qtys = qtys;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteVaruhint(entry);
            }
            writer.WriteUShort((ushort)qtys.Length);
            foreach (var entry in qtys)
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
            limit = reader.ReadUShort();
            qtys = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 qtys[i] = reader.ReadVaruhint();
            }
            

}


}


}