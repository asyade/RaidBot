


















// Generated on 06/26/2015 11:42:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class MonsterInGroupLightInformations
{

public const short Id = 395;
public virtual short TypeId
{
    get { return Id; }
}

public int creatureGenericId;
        public sbyte grade;
        

public MonsterInGroupLightInformations()
{
}

public MonsterInGroupLightInformations(int creatureGenericId, sbyte grade)
        {
            this.creatureGenericId = creatureGenericId;
            this.grade = grade;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(creatureGenericId);
            writer.WriteSByte(grade);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

creatureGenericId = reader.ReadInt();
            grade = reader.ReadSByte();
            if (grade < 0)
                throw new Exception("Forbidden value on grade = " + grade + ", it doesn't respect the following condition : grade < 0");
            

}


}


}