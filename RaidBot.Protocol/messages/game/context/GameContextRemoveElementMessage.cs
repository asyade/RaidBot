


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameContextRemoveElementMessage : NetworkMessage
{

public const uint Id = 251;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        

public GameContextRemoveElementMessage()
{
}

public GameContextRemoveElementMessage(int id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(id);
            

}

public override void Deserialize(ICustomDataReader reader)
{

id = reader.ReadInt();
            

}


}


}