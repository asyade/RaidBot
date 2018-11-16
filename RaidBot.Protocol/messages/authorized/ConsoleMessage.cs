


















// Generated on 06/26/2015 11:40:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ConsoleMessage : NetworkMessage
{

public const uint Id = 75;
public override uint MessageId
{
    get { return Id; }
}

public sbyte type;
        public string content;
        

public ConsoleMessage()
{
}

public ConsoleMessage(sbyte type, string content)
        {
            this.type = type;
            this.content = content;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(type);
            writer.WriteUTF(content);
            

}

public override void Deserialize(ICustomDataReader reader)
{

type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            content = reader.ReadUTF();
            

}


}


}