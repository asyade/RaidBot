


















// Generated on 06/26/2015 11:41:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChatClientMultiMessage : ChatAbstractClientMessage
{

public const uint Id = 861;
public override uint MessageId
{
    get { return Id; }
}

public sbyte channel;
        

public ChatClientMultiMessage()
{
}

public ChatClientMultiMessage(string content, sbyte channel)
         : base(content)
        {
            this.channel = channel;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(channel);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            channel = reader.ReadSByte();
            if (channel < 0)
                throw new Exception("Forbidden value on channel = " + channel + ", it doesn't respect the following condition : channel < 0");
            

}


}


}