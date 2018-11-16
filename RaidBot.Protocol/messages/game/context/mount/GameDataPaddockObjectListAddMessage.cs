


















// Generated on 06/26/2015 11:41:19
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameDataPaddockObjectListAddMessage : NetworkMessage
{

public const uint Id = 5992;
public override uint MessageId
{
    get { return Id; }
}

public Types.PaddockItem[] paddockItemDescription;
        

public GameDataPaddockObjectListAddMessage()
{
}

public GameDataPaddockObjectListAddMessage(Types.PaddockItem[] paddockItemDescription)
        {
            this.paddockItemDescription = paddockItemDescription;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)paddockItemDescription.Length);
            foreach (var entry in paddockItemDescription)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            paddockItemDescription = new Types.PaddockItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddockItemDescription[i] = new Types.PaddockItem();
                 paddockItemDescription[i].Deserialize(reader);
            }
            

}


}


}