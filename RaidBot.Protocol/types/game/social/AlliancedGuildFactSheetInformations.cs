


















// Generated on 06/26/2015 11:42:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AlliancedGuildFactSheetInformations : GuildInformations
{

public const short Id = 422;
public override short TypeId
{
    get { return Id; }
}

public Types.BasicNamedAllianceInformations allianceInfos;
        

public AlliancedGuildFactSheetInformations()
{
}

public AlliancedGuildFactSheetInformations(uint guildId, string guildName, Types.GuildEmblem guildEmblem, Types.BasicNamedAllianceInformations allianceInfos)
         : base(guildId, guildName, guildEmblem)
        {
            this.allianceInfos = allianceInfos;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            allianceInfos.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            allianceInfos = new Types.BasicNamedAllianceInformations();
            allianceInfos.Deserialize(reader);
            

}


}


}