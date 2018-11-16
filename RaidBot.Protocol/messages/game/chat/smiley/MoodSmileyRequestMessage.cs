


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MoodSmileyRequestMessage : NetworkMessage
{

public const uint Id = 6192;
public override uint MessageId
{
    get { return Id; }
}

public sbyte smileyId;
        

public MoodSmileyRequestMessage()
{
}

public MoodSmileyRequestMessage(sbyte smileyId)
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
            

}


}


}