


















// Generated on 06/26/2015 11:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildMotdMessage : NetworkMessage
{

public const uint Id = 6590;
public override uint MessageId
{
    get { return Id; }
}

public string content;
        public int timestamp;
        

public GuildMotdMessage()
{
}

public GuildMotdMessage(string content, int timestamp)
        {
            this.content = content;
            this.timestamp = timestamp;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(content);
            writer.WriteInt(timestamp);
            

}

public override void Deserialize(ICustomDataReader reader)
{

content = reader.ReadUTF();
            timestamp = reader.ReadInt();
            if (timestamp < 0)
                throw new Exception("Forbidden value on timestamp = " + timestamp + ", it doesn't respect the following condition : timestamp < 0");
            

}


}


}