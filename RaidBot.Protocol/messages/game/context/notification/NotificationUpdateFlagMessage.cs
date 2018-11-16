


















// Generated on 06/26/2015 11:41:20
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class NotificationUpdateFlagMessage : NetworkMessage
{

public const uint Id = 6090;
public override uint MessageId
{
    get { return Id; }
}

public ushort index;
        

public NotificationUpdateFlagMessage()
{
}

public NotificationUpdateFlagMessage(ushort index)
        {
            this.index = index;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(index);
            

}

public override void Deserialize(ICustomDataReader reader)
{

index = reader.ReadVaruhshort();
            if (index < 0)
                throw new Exception("Forbidden value on index = " + index + ", it doesn't respect the following condition : index < 0");
            

}


}


}