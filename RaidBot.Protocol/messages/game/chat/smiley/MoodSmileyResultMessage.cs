


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MoodSmileyResultMessage : NetworkMessage
{

public const uint Id = 6196;
public override uint MessageId
{
    get { return Id; }
}

public sbyte resultCode;
        public sbyte smileyId;
        

public MoodSmileyResultMessage()
{
}

public MoodSmileyResultMessage(sbyte resultCode, sbyte smileyId)
        {
            this.resultCode = resultCode;
            this.smileyId = smileyId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(resultCode);
            writer.WriteSByte(smileyId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

resultCode = reader.ReadSByte();
            if (resultCode < 0)
                throw new Exception("Forbidden value on resultCode = " + resultCode + ", it doesn't respect the following condition : resultCode < 0");
            smileyId = reader.ReadSByte();
            

}


}


}