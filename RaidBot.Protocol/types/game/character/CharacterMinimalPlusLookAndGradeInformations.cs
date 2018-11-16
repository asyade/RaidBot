


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class CharacterMinimalPlusLookAndGradeInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 193;
public override short TypeId
{
    get { return Id; }
}

public uint grade;
        

public CharacterMinimalPlusLookAndGradeInformations()
{
}

public CharacterMinimalPlusLookAndGradeInformations(uint id, byte level, string name, Types.EntityLook entityLook, uint grade)
         : base(id, level, name, entityLook)
        {
            this.grade = grade;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(grade);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            grade = reader.ReadVaruhint();
            if (grade < 0)
                throw new Exception("Forbidden value on grade = " + grade + ", it doesn't respect the following condition : grade < 0");
            

}


}


}