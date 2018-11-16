


















// Generated on 06/26/2015 11:40:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class BasicPingMessage : NetworkMessage
{

public const uint Id = 182;
public override uint MessageId
{
    get { return Id; }
}

public bool quiet;
        

public BasicPingMessage()
{
}

public BasicPingMessage(bool quiet)
        {
            this.quiet = quiet;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(quiet);
            

}

public override void Deserialize(ICustomDataReader reader)
{

quiet = reader.ReadBoolean();
            

}


}


}