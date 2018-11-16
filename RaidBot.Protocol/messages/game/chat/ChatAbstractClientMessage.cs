


















// Generated on 06/26/2015 11:41:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChatAbstractClientMessage : NetworkMessage
{

public const uint Id = 850;
public override uint MessageId
{
    get { return Id; }
}

public string content;
        

public ChatAbstractClientMessage()
{
}

public ChatAbstractClientMessage(string content)
        {
            this.content = content;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(content);
            

}

public override void Deserialize(ICustomDataReader reader)
{

content = reader.ReadUTF();
            

}


}


}