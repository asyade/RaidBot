


















// Generated on 06/26/2015 11:41:22
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class EmoteListMessage : NetworkMessage
{

public const uint Id = 5689;
public override uint MessageId
{
    get { return Id; }
}

public byte[] emoteIds;
        

public EmoteListMessage()
{
}

public EmoteListMessage(byte[] emoteIds)
        {
            this.emoteIds = emoteIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)emoteIds.Length);
            foreach (var entry in emoteIds)
            {
                 writer.WriteByte(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            emoteIds = new byte[limit];
            for (int i = 0; i < limit; i++)
            {
                 emoteIds[i] = reader.ReadByte();
            }
            

}


}


}