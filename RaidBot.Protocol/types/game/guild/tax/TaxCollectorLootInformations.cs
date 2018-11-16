


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class TaxCollectorLootInformations : TaxCollectorComplementaryInformations
{

public const short Id = 372;
public override short TypeId
{
    get { return Id; }
}

public uint kamas;
        public ulong experience;
        public uint pods;
        public uint itemsValue;
        

public TaxCollectorLootInformations()
{
}

public TaxCollectorLootInformations(uint kamas, ulong experience, uint pods, uint itemsValue)
        {
            this.kamas = kamas;
            this.experience = experience;
            this.pods = pods;
            this.itemsValue = itemsValue;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(kamas);
            writer.WriteVaruhlong(experience);
            writer.WriteVaruhint(pods);
            writer.WriteVaruhint(itemsValue);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            kamas = reader.ReadVaruhint();
            if (kamas < 0)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            experience = reader.ReadVaruhlong();
            if (experience < 0 || experience > 9.007199254740992E15)
                throw new Exception("Forbidden value on experience = " + experience + ", it doesn't respect the following condition : experience < 0 || experience > 9.007199254740992E15");
            pods = reader.ReadVaruhint();
            if (pods < 0)
                throw new Exception("Forbidden value on pods = " + pods + ", it doesn't respect the following condition : pods < 0");
            itemsValue = reader.ReadVaruhint();
            if (itemsValue < 0)
                throw new Exception("Forbidden value on itemsValue = " + itemsValue + ", it doesn't respect the following condition : itemsValue < 0");
            

}


}


}