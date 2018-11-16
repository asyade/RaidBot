


















// Generated on 06/26/2015 11:41:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class LoginQueueStatusMessage : NetworkMessage
{

public const uint Id = 10;
public override uint MessageId
{
    get { return Id; }
}

public ushort position;
        public ushort total;
        

public LoginQueueStatusMessage()
{
}

public LoginQueueStatusMessage(ushort position, ushort total)
        {
            this.position = position;
            this.total = total;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort(position);
            writer.WriteUShort(total);
            

}

public override void Deserialize(ICustomDataReader reader)
{

position = reader.ReadUShort();
            if (position < 0 || position > 65535)
                throw new Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 65535");
            total = reader.ReadUShort();
            if (total < 0 || total > 65535)
                throw new Exception("Forbidden value on total = " + total + ", it doesn't respect the following condition : total < 0 || total > 65535");
            

}


}


}