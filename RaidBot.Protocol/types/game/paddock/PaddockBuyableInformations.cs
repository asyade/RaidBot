


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PaddockBuyableInformations : PaddockInformations
{

public const short Id = 130;
public override short TypeId
{
    get { return Id; }
}

public uint price;
        public bool locked;
        

public PaddockBuyableInformations()
{
}

public PaddockBuyableInformations(ushort maxOutdoorMount, ushort maxItems, uint price, bool locked)
         : base(maxOutdoorMount, maxItems)
        {
            this.price = price;
            this.locked = locked;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(price);
            writer.WriteBoolean(locked);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            price = reader.ReadVaruhint();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            locked = reader.ReadBoolean();
            

}


}


}