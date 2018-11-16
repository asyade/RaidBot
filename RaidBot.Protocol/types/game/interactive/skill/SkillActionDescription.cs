


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class SkillActionDescription
{

public const short Id = 102;
public virtual short TypeId
{
    get { return Id; }
}

public ushort skillId;
        

public SkillActionDescription()
{
}

public SkillActionDescription(ushort skillId)
        {
            this.skillId = skillId;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(skillId);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

skillId = reader.ReadVaruhshort();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}


}


}