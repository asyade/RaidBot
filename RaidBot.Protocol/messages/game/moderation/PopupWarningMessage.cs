


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PopupWarningMessage : NetworkMessage
{

public const uint Id = 6134;
public override uint MessageId
{
    get { return Id; }
}

public byte lockDuration;
        public string author;
        public string content;
        

public PopupWarningMessage()
{
}

public PopupWarningMessage(byte lockDuration, string author, string content)
        {
            this.lockDuration = lockDuration;
            this.author = author;
            this.content = content;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteByte(lockDuration);
            writer.WriteUTF(author);
            writer.WriteUTF(content);
            

}

public override void Deserialize(ICustomDataReader reader)
{

lockDuration = reader.ReadByte();
            if (lockDuration < 0 || lockDuration > 255)
                throw new Exception("Forbidden value on lockDuration = " + lockDuration + ", it doesn't respect the following condition : lockDuration < 0 || lockDuration > 255");
            author = reader.ReadUTF();
            content = reader.ReadUTF();
            

}


}


}