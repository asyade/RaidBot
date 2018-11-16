


















// Generated on 06/26/2015 11:41:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PlayerStatusUpdateRequestMessage : NetworkMessage
{

public const uint Id = 6387;
public override uint MessageId
{
    get { return Id; }
}

public Types.PlayerStatus status;
        

public PlayerStatusUpdateRequestMessage()
{
}

public PlayerStatusUpdateRequestMessage(Types.PlayerStatus status)
        {
            this.status = status;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

status = Types.ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadShort());
            status.Deserialize(reader);
            

}


}


}