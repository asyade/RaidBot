


















// Generated on 06/26/2015 11:41:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class BasicTimeMessage : NetworkMessage
{

public const uint Id = 175;
public override uint MessageId
{
    get { return Id; }
}

public double timestamp;
        public short timezoneOffset;
        

public BasicTimeMessage()
{
}

public BasicTimeMessage(double timestamp, short timezoneOffset)
        {
            this.timestamp = timestamp;
            this.timezoneOffset = timezoneOffset;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteDouble(timestamp);
            writer.WriteShort(timezoneOffset);
            

}

public override void Deserialize(ICustomDataReader reader)
{

timestamp = reader.ReadDouble();
            if (timestamp < 0 || timestamp > 9.007199254740992E15)
                throw new Exception("Forbidden value on timestamp = " + timestamp + ", it doesn't respect the following condition : timestamp < 0 || timestamp > 9.007199254740992E15");
            timezoneOffset = reader.ReadShort();
            

}


}


}