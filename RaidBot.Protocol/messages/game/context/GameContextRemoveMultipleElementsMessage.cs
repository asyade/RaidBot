


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameContextRemoveMultipleElementsMessage : NetworkMessage
{

public const uint Id = 252;
public override uint MessageId
{
    get { return Id; }
}

public int[] id;
        

public GameContextRemoveMultipleElementsMessage()
{
}

public GameContextRemoveMultipleElementsMessage(int[] id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)id.Length);
            foreach (var entry in id)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            id = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 id[i] = reader.ReadInt();
            }
            

}


}


}