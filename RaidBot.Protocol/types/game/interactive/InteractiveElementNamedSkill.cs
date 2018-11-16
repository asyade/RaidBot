


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class InteractiveElementNamedSkill : InteractiveElementSkill
{

public const short Id = 220;
public override short TypeId
{
    get { return Id; }
}

public uint nameId;
        

public InteractiveElementNamedSkill()
{
}

public InteractiveElementNamedSkill(uint skillId, int skillInstanceUid, uint nameId)
         : base(skillId, skillInstanceUid)
        {
            this.nameId = nameId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(nameId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            nameId = reader.ReadVaruhint();
            if (nameId < 0)
                throw new Exception("Forbidden value on nameId = " + nameId + ", it doesn't respect the following condition : nameId < 0");
            

}


}


}