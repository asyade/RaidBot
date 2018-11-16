


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GoldItem : Item
{

public const short Id = 123;
public override short TypeId
{
    get { return Id; }
}

public uint sum;
        

public GoldItem()
{
}

public GoldItem(uint sum)
        {
            this.sum = sum;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(sum);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            sum = reader.ReadVaruhint();
            if (sum < 0)
                throw new Exception("Forbidden value on sum = " + sum + ", it doesn't respect the following condition : sum < 0");
            

}


}


}