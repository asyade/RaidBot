


















// Generated on 06/26/2015 11:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildPaddockBoughtMessage : NetworkMessage
{

public const uint Id = 5952;
public override uint MessageId
{
    get { return Id; }
}

public Types.PaddockContentInformations paddockInfo;
        

public GuildPaddockBoughtMessage()
{
}

public GuildPaddockBoughtMessage(Types.PaddockContentInformations paddockInfo)
        {
            this.paddockInfo = paddockInfo;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

paddockInfo.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

paddockInfo = new Types.PaddockContentInformations();
            paddockInfo.Deserialize(reader);
            

}


}


}