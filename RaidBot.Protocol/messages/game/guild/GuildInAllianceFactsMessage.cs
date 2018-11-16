


















// Generated on 06/26/2015 11:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildInAllianceFactsMessage : GuildFactsMessage
{

public const uint Id = 6422;
public override uint MessageId
{
    get { return Id; }
}

public Types.BasicNamedAllianceInformations allianceInfos;
        

public GuildInAllianceFactsMessage()
{
}

public GuildInAllianceFactsMessage(Types.GuildFactSheetInformations infos, int creationDate, ushort nbTaxCollectors, bool enabled, Types.CharacterMinimalInformations[] members, Types.BasicNamedAllianceInformations allianceInfos)
         : base(infos, creationDate, nbTaxCollectors, enabled, members)
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