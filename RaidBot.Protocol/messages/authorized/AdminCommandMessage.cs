


















// Generated on 06/26/2015 11:40:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AdminCommandMessage : NetworkMessage
{

public const uint Id = 76;
public override uint MessageId
{
    get { return Id; }
}

public string content;
        

public AdminCommandMessage()
{
}

public AdminCommandMessage(string content)
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