


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectEffectLadder : ObjectEffectCreature
{

public const short Id = 81;
public override short TypeId
{
    get { return Id; }
}

public uint monsterCount;
        

public ObjectEffectLadder()
{
}

public ObjectEffectLadder(ushort actionId, ushort monsterFamilyId, uint monsterCount)
         : base(actionId, monsterFamilyId)
        {
            this.monsterCount = monsterCount;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(monsterCount);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            monsterCount = reader.ReadVaruhint();
            if (monsterCount < 0)
                throw new Exception("Forbidden value on monsterCount = " + monsterCount + ", it doesn't respect the following condition : monsterCount < 0");
            

}


}


}