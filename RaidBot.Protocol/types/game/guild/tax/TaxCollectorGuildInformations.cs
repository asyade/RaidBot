


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class TaxCollectorGuildInformations : TaxCollectorComplementaryInformations
{

public const short Id = 446;
public override short TypeId
{
    get { return Id; }
}

public Types.BasicGuildInformations guild;
        

public TaxCollectorGuildInformations()
{
}

public TaxCollectorGuildInformations(Types.BasicGuildInformations guild)
        {
            this.guild = guild;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            guild.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
            

}


}


}