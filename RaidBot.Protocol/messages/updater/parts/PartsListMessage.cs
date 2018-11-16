


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartsListMessage : NetworkMessage
{

public const uint Id = 1502;
public override uint MessageId
{
    get { return Id; }
}

public Types.ContentPart[] parts;
        

public PartsListMessage()
{
}

public PartsListMessage(Types.ContentPart[] parts)
        {
            this.parts = parts;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)parts.Length);
            foreach (var entry in parts)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            parts = new Types.ContentPart[limit];
            for (int i = 0; i < limit; i++)
            {
                 parts[i] = new Types.ContentPart();
                 parts[i].Deserialize(reader);
            }
            

}


}


}