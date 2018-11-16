


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InteractiveUsedMessage : NetworkMessage
{

public const uint Id = 5745;
public override uint MessageId
{
    get { return Id; }
}

public uint entityId;
        public uint elemId;
        public ushort skillId;
        public ushort duration;
        

public InteractiveUsedMessage()
{
}

public InteractiveUsedMessage(uint entityId, uint elemId, ushort skillId, ushort duration)
        {
            this.entityId = entityId;
            this.elemId = elemId;
            this.skillId = skillId;
            this.duration = duration;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(entityId);
            writer.WriteVaruhint(elemId);
            writer.WriteVaruhshort(skillId);
            writer.WriteVaruhshort(duration);
            

}

public override void Deserialize(ICustomDataReader reader)
{

entityId = reader.ReadVaruhint();
            if (entityId < 0)
                throw new Exception("Forbidden value on entityId = " + entityId + ", it doesn't respect the following condition : entityId < 0");
            elemId = reader.ReadVaruhint();
            if (elemId < 0)
                throw new Exception("Forbidden value on elemId = " + elemId + ", it doesn't respect the following condition : elemId < 0");
            skillId = reader.ReadVaruhshort();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            duration = reader.ReadVaruhshort();
            if (duration < 0)
                throw new Exception("Forbidden value on duration = " + duration + ", it doesn't respect the following condition : duration < 0");
            

}


}


}