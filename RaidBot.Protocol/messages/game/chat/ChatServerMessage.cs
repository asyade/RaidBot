


















// Generated on 06/26/2015 11:41:12
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChatServerMessage : ChatAbstractServerMessage
{

public const uint Id = 881;
public override uint MessageId
{
    get { return Id; }
}

public int senderId;
        public string senderName;
        public int senderAccountId;
        

public ChatServerMessage()
{
}

public ChatServerMessage(sbyte channel, string content, int timestamp, string fingerprint, int senderId, string senderName, int senderAccountId)
         : base(channel, content, timestamp, fingerprint)
        {
            this.senderId = senderId;
            this.senderName = senderName;
            this.senderAccountId = senderAccountId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(senderId);
            writer.WriteUTF(senderName);
            writer.WriteInt(senderAccountId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            senderId = reader.ReadInt();
            senderName = reader.ReadUTF();
            senderAccountId = reader.ReadInt();
            if (senderAccountId < 0)
                throw new Exception("Forbidden value on senderAccountId = " + senderAccountId + ", it doesn't respect the following condition : senderAccountId < 0");
            

}


}


}