


















// Generated on 06/26/2015 11:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeObjectMessage : NetworkMessage
{

public const uint Id = 5515;
public override uint MessageId
{
    get { return Id; }
}

public bool remote;
        

public ExchangeObjectMessage()
{
}

public ExchangeObjectMessage(bool remote)
        {
            this.remote = remote;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(remote);
            

}

public override void Deserialize(ICustomDataReader reader)
{

remote = reader.ReadBoolean();
            

}


}


}