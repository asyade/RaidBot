


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TaxCollectorDialogQuestionBasicMessage : NetworkMessage
{

public const uint Id = 5619;
public override uint MessageId
{
    get { return Id; }
}

public Types.BasicGuildInformations guildInfo;
        

public TaxCollectorDialogQuestionBasicMessage()
{
}

public TaxCollectorDialogQuestionBasicMessage(Types.BasicGuildInformations guildInfo)
        {
            this.guildInfo = guildInfo;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

guildInfo.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

guildInfo = new Types.BasicGuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}