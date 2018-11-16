


















// Generated on 06/26/2015 11:41:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SequenceStartMessage : NetworkMessage
{

public const uint Id = 955;
public override uint MessageId
{
    get { return Id; }
}

public sbyte sequenceType;
        public int authorId;
        

public SequenceStartMessage()
{
}

public SequenceStartMessage(sbyte sequenceType, int authorId)
        {
            this.sequenceType = sequenceType;
            this.authorId = authorId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(sequenceType);
            writer.WriteInt(authorId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

sequenceType = reader.ReadSByte();
            authorId = reader.ReadInt();
            

}


}


}