


















// Generated on 06/26/2015 11:41:55
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismsListMessage : NetworkMessage
{

public const uint Id = 6440;
public override uint MessageId
{
    get { return Id; }
}

public Types.PrismSubareaEmptyInfo[] prisms;
        

public PrismsListMessage()
{
}

public PrismsListMessage(Types.PrismSubareaEmptyInfo[] prisms)
        {
            this.prisms = prisms;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)prisms.Length);
            foreach (var entry in prisms)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            prisms = new Types.PrismSubareaEmptyInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 prisms[i] = Types.ProtocolTypeManager.GetInstance<Types.PrismSubareaEmptyInfo>(reader.ReadShort());
                 prisms[i].Deserialize(reader);
            }
            

}


}


}