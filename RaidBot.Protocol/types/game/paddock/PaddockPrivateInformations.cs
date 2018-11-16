


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PaddockPrivateInformations : PaddockAbandonnedInformations
{

public const short Id = 131;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildInformations guildInfo;
        

public PaddockPrivateInformations()
{
}

public PaddockPrivateInformations(ushort maxOutdoorMount, ushort maxItems, uint price, bool locked, int guildId, Types.GuildInformations guildInfo)
         : base(maxOutdoorMount, maxItems, price, locked, guildId)
        {
            this.guildInfo = guildInfo;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            guildInfo.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}