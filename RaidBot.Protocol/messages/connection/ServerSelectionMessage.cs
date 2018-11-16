


















// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ServerSelectionMessage : NetworkMessage
{

public const uint Id = 40;
public override uint MessageId
{
    get { return Id; }
}

public ushort serverId;
        

public ServerSelectionMessage()
{
}

public ServerSelectionMessage(ushort serverId)
        {
            this.serverId = serverId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(serverId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

serverId = reader.ReadVaruhshort();
            if (serverId < 0)
                throw new Exception("Forbidden value on serverId = " + serverId + ", it doesn't respect the following condition : serverId < 0");
            

}


}


}