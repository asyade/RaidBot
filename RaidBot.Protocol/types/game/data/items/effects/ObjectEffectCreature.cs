


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectEffectCreature : ObjectEffect
{

public const short Id = 71;
public override short TypeId
{
    get { return Id; }
}

public ushort monsterFamilyId;
        

public ObjectEffectCreature()
{
}

public ObjectEffectCreature(ushort actionId, ushort monsterFamilyId)
         : base(actionId)
        {
            this.monsterFamilyId = monsterFamilyId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(monsterFamilyId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            monsterFamilyId = reader.ReadVaruhshort();
            if (monsterFamilyId < 0)
                throw new Exception("Forbidden value on monsterFamilyId = " + monsterFamilyId + ", it doesn't respect the following condition : monsterFamilyId < 0");
            

}


}


}