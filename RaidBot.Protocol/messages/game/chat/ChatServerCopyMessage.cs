


















// Generated on 06/26/2015 11:41:12
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChatServerCopyMessage : ChatAbstractServerMessage
{

public const uint Id = 882;
public override uint MessageId
{
    get { return Id; }
}

public uint receiverId;
        public string receiverName;
        

public ChatServerCopyMessage()
{
}

public ChatServerCopyMessage(sbyte channel, string content, int timestamp, string fingerprint, uint receiverId, string receiverName)
         : base(channel, content, timestamp, fingerprint)
        {
            this.receiverId = receiverId;
            this.receiverName = receiverName;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(receiverId);
            writer.WriteUTF(receiverName);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            receiverId = reader.ReadVaruhint();
            if (receiverId < 0)
                throw new Exception("Forbidden value on receiverId = " + receiverId + ", it doesn't respect the following condition : receiverId < 0");
            receiverName = reader.ReadUTF();
            

}


}


}