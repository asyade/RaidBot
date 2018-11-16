


















// Generated on 06/26/2015 11:41:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CurrentServerStatusUpdateMessage : NetworkMessage
{

public const uint Id = 6525;
public override uint MessageId
{
    get { return Id; }
}

public sbyte status;
        

public CurrentServerStatusUpdateMessage()
{
}

public CurrentServerStatusUpdateMessage(sbyte status)
        {
            this.status = status;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(status);
            

}

public override void Deserialize(ICustomDataReader reader)
{

status = reader.ReadSByte();
            if (status < 0)
                throw new Exception("Forbidden value on status = " + status + ", it doesn't respect the following condition : status < 0");
            

}


}


}