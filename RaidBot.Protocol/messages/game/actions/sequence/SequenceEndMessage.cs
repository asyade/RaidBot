


















// Generated on 06/26/2015 11:41:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SequenceEndMessage : NetworkMessage
{

public const uint Id = 956;
public override uint MessageId
{
    get { return Id; }
}

public ushort actionId;
        public int authorId;
        public sbyte sequenceType;
        

public SequenceEndMessage()
{
}

public SequenceEndMessage(ushort actionId, int authorId, sbyte sequenceType)
        {
            this.actionId = actionId;
            this.authorId = authorId;
            this.sequenceType = sequenceType;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(actionId);
            writer.WriteInt(authorId);
            writer.WriteSByte(sequenceType);
            

}

public override void Deserialize(ICustomDataReader reader)
{

actionId = reader.ReadVaruhshort();
            if (actionId < 0)
                throw new Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            authorId = reader.ReadInt();
            sequenceType = reader.ReadSByte();
            

}


}


}