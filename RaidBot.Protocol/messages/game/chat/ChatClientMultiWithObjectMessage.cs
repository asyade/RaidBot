


















// Generated on 06/26/2015 11:41:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChatClientMultiWithObjectMessage : ChatClientMultiMessage
{

public const uint Id = 862;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objects;
        

public ChatClientMultiWithObjectMessage()
{
}

public ChatClientMultiWithObjectMessage(string content, sbyte channel, Types.ObjectItem[] objects)
         : base(content, channel)
        {
            this.objects = objects;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.ObjectItem();
                 objects[i].Deserialize(reader);
            }
            

}


}


}