


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PaddockAbandonnedInformations : PaddockBuyableInformations
{

public const short Id = 133;
public override short TypeId
{
    get { return Id; }
}

public int guildId;
        

public PaddockAbandonnedInformations()
{
}

public PaddockAbandonnedInformations(ushort maxOutdoorMount, ushort maxItems, uint price, bool locked, int guildId)
         : base(maxOutdoorMount, maxItems, price, locked)
        {
            this.guildId = guildId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(guildId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            guildId = reader.ReadInt();
            

}


}


}