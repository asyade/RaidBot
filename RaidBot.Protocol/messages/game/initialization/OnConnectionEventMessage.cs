


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class OnConnectionEventMessage : NetworkMessage
{

public const uint Id = 5726;
public override uint MessageId
{
    get { return Id; }
}

public sbyte eventType;
        

public OnConnectionEventMessage()
{
}

public OnConnectionEventMessage(sbyte eventType)
        {
            this.eventType = eventType;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(eventType);
            

}

public override void Deserialize(ICustomDataReader reader)
{

eventType = reader.ReadSByte();
            if (eventType < 0)
                throw new Exception("Forbidden value on eventType = " + eventType + ", it doesn't respect the following condition : eventType < 0");
            

}


}


}