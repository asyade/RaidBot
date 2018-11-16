


















// Generated on 06/26/2015 11:41:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChatClientPrivateMessage : ChatAbstractClientMessage
{

public const uint Id = 851;
public override uint MessageId
{
    get { return Id; }
}

public string receiver;
        

public ChatClientPrivateMessage()
{
}

public ChatClientPrivateMessage(string content, string receiver)
         : base(content)
        {
            this.receiver = receiver;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(receiver);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            receiver = reader.ReadUTF();
            

}


}


}