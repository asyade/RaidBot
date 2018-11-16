


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InteractiveUseEndedMessage : NetworkMessage
{

public const uint Id = 6112;
public override uint MessageId
{
    get { return Id; }
}

public uint elemId;
        public ushort skillId;
        

public InteractiveUseEndedMessage()
{
}

public InteractiveUseEndedMessage(uint elemId, ushort skillId)
        {
            this.elemId = elemId;
            this.skillId = skillId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(elemId);
            writer.WriteVaruhshort(skillId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

elemId = reader.ReadVaruhint();
            if (elemId < 0)
                throw new Exception("Forbidden value on elemId = " + elemId + ", it doesn't respect the following condition : elemId < 0");
            skillId = reader.ReadVaruhshort();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}


}


}