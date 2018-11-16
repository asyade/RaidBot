


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PaddockItem : ObjectItemInRolePlay
{

public const short Id = 185;
public override short TypeId
{
    get { return Id; }
}

public Types.ItemDurability durability;
        

public PaddockItem()
{
}

public PaddockItem(ushort cellId, ushort objectGID, Types.ItemDurability durability)
         : base(cellId, objectGID)
        {
            this.durability = durability;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            durability.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            durability = new Types.ItemDurability();
            durability.Deserialize(reader);
            

}


}


}