


















// Generated on 06/26/2015 11:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class LivingObjectMessageMessage : NetworkMessage
{

public const uint Id = 6065;
public override uint MessageId
{
    get { return Id; }
}

public ushort msgId;
        public int timeStamp;
        public string owner;
        public ushort objectGenericId;
        

public LivingObjectMessageMessage()
{
}

public LivingObjectMessageMessage(ushort msgId, int timeStamp, string owner, ushort objectGenericId)
        {
            this.msgId = msgId;
            this.timeStamp = timeStamp;
            this.owner = owner;
            this.objectGenericId = objectGenericId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(msgId);
            writer.WriteInt(timeStamp);
            writer.WriteUTF(owner);
            writer.WriteVaruhshort(objectGenericId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

msgId = reader.ReadVaruhshort();
            if (msgId < 0)
                throw new Exception("Forbidden value on msgId = " + msgId + ", it doesn't respect the following condition : msgId < 0");
            timeStamp = reader.ReadInt();
            if (timeStamp < 0)
                throw new Exception("Forbidden value on timeStamp = " + timeStamp + ", it doesn't respect the following condition : timeStamp < 0");
            owner = reader.ReadUTF();
            objectGenericId = reader.ReadVaruhshort();
            if (objectGenericId < 0)
                throw new Exception("Forbidden value on objectGenericId = " + objectGenericId + ", it doesn't respect the following condition : objectGenericId < 0");
            

}


}


}