


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightResultPvpData : FightResultAdditionalData
{

public const short Id = 190;
public override short TypeId
{
    get { return Id; }
}

public byte grade;
        public ushort minHonorForGrade;
        public ushort maxHonorForGrade;
        public ushort honor;
        public short honorDelta;
        

public FightResultPvpData()
{
}

public FightResultPvpData(byte grade, ushort minHonorForGrade, ushort maxHonorForGrade, ushort honor, short honorDelta)
        {
            this.grade = grade;
            this.minHonorForGrade = minHonorForGrade;
            this.maxHonorForGrade = maxHonorForGrade;
            this.honor = honor;
            this.honorDelta = honorDelta;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteByte(grade);
            writer.WriteVaruhshort(minHonorForGrade);
            writer.WriteVaruhshort(maxHonorForGrade);
            writer.WriteVaruhshort(honor);
            writer.WriteVarshort(honorDelta);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            grade = reader.ReadByte();
            if (grade < 0 || grade > 255)
                throw new Exception("Forbidden value on grade = " + grade + ", it doesn't respect the following condition : grade < 0 || grade > 255");
            minHonorForGrade = reader.ReadVaruhshort();
            if (minHonorForGrade < 0 || minHonorForGrade > 20000)
                throw new Exception("Forbidden value on minHonorForGrade = " + minHonorForGrade + ", it doesn't respect the following condition : minHonorForGrade < 0 || minHonorForGrade > 20000");
            maxHonorForGrade = reader.ReadVaruhshort();
            if (maxHonorForGrade < 0 || maxHonorForGrade > 20000)
                throw new Exception("Forbidden value on maxHonorForGrade = " + maxHonorForGrade + ", it doesn't respect the following condition : maxHonorForGrade < 0 || maxHonorForGrade > 20000");
            honor = reader.ReadVaruhshort();
            if (honor < 0 || honor > 20000)
                throw new Exception("Forbidden value on honor = " + honor + ", it doesn't respect the following condition : honor < 0 || honor > 20000");
            honorDelta = reader.ReadVarshort();
            

}


}


}