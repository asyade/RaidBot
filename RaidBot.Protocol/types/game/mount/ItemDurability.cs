


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ItemDurability
{

public const short Id = 168;
public virtual short TypeId
{
    get { return Id; }
}

public short durability;
        public short durabilityMax;
        

public ItemDurability()
{
}

public ItemDurability(short durability, short durabilityMax)
        {
            this.durability = durability;
            this.durabilityMax = durabilityMax;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(durability);
            writer.WriteShort(durabilityMax);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

durability = reader.ReadShort();
            durabilityMax = reader.ReadShort();
            

}


}


}