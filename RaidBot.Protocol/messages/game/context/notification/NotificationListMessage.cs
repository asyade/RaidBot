


















// Generated on 06/26/2015 11:41:20
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class NotificationListMessage : NetworkMessage
{

public const uint Id = 6087;
public override uint MessageId
{
    get { return Id; }
}

public int[] flags;
        

public NotificationListMessage()
{
}

public NotificationListMessage(int[] flags)
        {
            this.flags = flags;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)flags.Length);
            foreach (var entry in flags)
            {
                 writer.WriteVarint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            flags = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 flags[i] = reader.ReadVarint();
            }
            

}


}


}