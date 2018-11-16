


















// Generated on 06/26/2015 11:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InventoryContentMessage : NetworkMessage
{

public const uint Id = 3016;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objects;
        public uint kamas;
        

public InventoryContentMessage()
{
}

public InventoryContentMessage(Types.ObjectItem[] objects, uint kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVaruhint(kamas);
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.ObjectItem();
                 objects[i].Deserialize(reader);
            }
            kamas = reader.ReadVaruhint();
            if (kamas < 0)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            

}


}


}