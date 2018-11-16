


















// Generated on 06/26/2015 11:41:12
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChatSmileyRequestMessage : NetworkMessage
{

public const uint Id = 800;
public override uint MessageId
{
    get { return Id; }
}

public sbyte smileyId;
        

public ChatSmileyRequestMessage()
{
}

public ChatSmileyRequestMessage(sbyte smileyId)
        {
            this.smileyId = smileyId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(smileyId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

smileyId = reader.ReadSByte();
            if (smileyId < 0)
                throw new Exception("Forbidden value on smileyId = " + smileyId + ", it doesn't respect the following condition : smileyId < 0");
            

}


}


}