


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AlliancePrismInformation : PrismInformation
{

public const short Id = 427;
public override short TypeId
{
    get { return Id; }
}

public Types.AllianceInformations alliance;
        

public AlliancePrismInformation()
{
}

public AlliancePrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount, Types.AllianceInformations alliance)
         : base(typeId, state, nextVulnerabilityDate, placementDate, rewardTokenCount)
        {
            this.alliance = alliance;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            alliance.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            alliance = new Types.AllianceInformations();
            alliance.Deserialize(reader);
            

}


}


}