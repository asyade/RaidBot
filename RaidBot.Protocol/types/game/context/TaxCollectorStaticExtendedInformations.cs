


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class TaxCollectorStaticExtendedInformations : TaxCollectorStaticInformations
{

public const short Id = 440;
public override short TypeId
{
    get { return Id; }
}

public Types.AllianceInformations allianceIdentity;
        

public TaxCollectorStaticExtendedInformations()
{
}

public TaxCollectorStaticExtendedInformations(ushort firstNameId, ushort lastNameId, Types.GuildInformations guildIdentity, Types.AllianceInformations allianceIdentity)
         : base(firstNameId, lastNameId, guildIdentity)
        {
            this.allianceIdentity = allianceIdentity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            allianceIdentity.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            allianceIdentity = new Types.AllianceInformations();
            allianceIdentity.Deserialize(reader);
            

}


}


}