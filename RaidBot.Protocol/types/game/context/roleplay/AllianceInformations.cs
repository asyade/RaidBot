


















// Generated on 06/26/2015 11:42:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AllianceInformations : BasicNamedAllianceInformations
{

public const short Id = 417;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildEmblem allianceEmblem;
        

public AllianceInformations()
{
}

public AllianceInformations(uint allianceId, string allianceTag, string allianceName, Types.GuildEmblem allianceEmblem)
         : base(allianceId, allianceTag, allianceName)
        {
            this.allianceEmblem = allianceEmblem;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            allianceEmblem.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            allianceEmblem = new Types.GuildEmblem();
            allianceEmblem.Deserialize(reader);
            

}


}


}