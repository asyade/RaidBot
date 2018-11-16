


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightLoot
{

public const short Id = 41;
public virtual short TypeId
{
    get { return Id; }
}

public ushort[] objects;
        public uint kamas;
        

public FightLoot()
{
}

public FightLoot(ushort[] objects, uint kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)objects.Length);
            foreach (var entry in objects)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteVaruhint(kamas);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            objects = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = reader.ReadVaruhshort();
            }
            kamas = reader.ReadVaruhint();
            if (kamas < 0)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            

}


}


}