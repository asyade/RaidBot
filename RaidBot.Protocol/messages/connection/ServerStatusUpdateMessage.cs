


















// Generated on 06/26/2015 11:40:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ServerStatusUpdateMessage : NetworkMessage
{

public const uint Id = 50;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameServerInformations server;
        

public ServerStatusUpdateMessage()
{
}

public ServerStatusUpdateMessage(Types.GameServerInformations server)
        {
            this.server = server;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

server.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

server = new Types.GameServerInformations();
            server.Deserialize(reader);
            

}


}


}