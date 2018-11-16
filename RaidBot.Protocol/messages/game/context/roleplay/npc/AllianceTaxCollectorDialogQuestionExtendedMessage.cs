


















// Generated on 06/26/2015 11:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceTaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionExtendedMessage
{

public const uint Id = 6445;
public override uint MessageId
{
    get { return Id; }
}

public Types.BasicNamedAllianceInformations alliance;
        

public AllianceTaxCollectorDialogQuestionExtendedMessage()
{
}

public AllianceTaxCollectorDialogQuestionExtendedMessage(Types.BasicGuildInformations guildInfo, ushort maxPods, ushort prospecting, ushort wisdom, sbyte taxCollectorsCount, int taxCollectorAttack, uint kamas, ulong experience, uint pods, uint itemsValue, Types.BasicNamedAllianceInformations alliance)
         : base(guildInfo, maxPods, prospecting, wisdom, taxCollectorsCount, taxCollectorAttack, kamas, experience, pods, itemsValue)
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
            alliance = new Types.BasicNamedAllianceInformations();
            alliance.Deserialize(reader);
            

}


}


}