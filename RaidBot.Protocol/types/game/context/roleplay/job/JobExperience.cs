


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class JobExperience
{

public const short Id = 98;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte jobId;
        public byte jobLevel;
        public ulong jobXP;
        public ulong jobXpLevelFloor;
        public ulong jobXpNextLevelFloor;
        

public JobExperience()
{
}

public JobExperience(sbyte jobId, byte jobLevel, ulong jobXP, ulong jobXpLevelFloor, ulong jobXpNextLevelFloor)
        {
            this.jobId = jobId;
            this.jobLevel = jobLevel;
            this.jobXP = jobXP;
            this.jobXpLevelFloor = jobXpLevelFloor;
            this.jobXpNextLevelFloor = jobXpNextLevelFloor;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(jobId);
            writer.WriteByte(jobLevel);
            writer.WriteVaruhlong(jobXP);
            writer.WriteVaruhlong(jobXpLevelFloor);
            writer.WriteVaruhlong(jobXpNextLevelFloor);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
            jobLevel = reader.ReadByte();
            if (jobLevel < 0 || jobLevel > 255)
                throw new Exception("Forbidden value on jobLevel = " + jobLevel + ", it doesn't respect the following condition : jobLevel < 0 || jobLevel > 255");
            jobXP = reader.ReadVaruhlong();
            if (jobXP < 0 || jobXP > 9.007199254740992E15)
                throw new Exception("Forbidden value on jobXP = " + jobXP + ", it doesn't respect the following condition : jobXP < 0 || jobXP > 9.007199254740992E15");
            jobXpLevelFloor = reader.ReadVaruhlong();
            if (jobXpLevelFloor < 0 || jobXpLevelFloor > 9.007199254740992E15)
                throw new Exception("Forbidden value on jobXpLevelFloor = " + jobXpLevelFloor + ", it doesn't respect the following condition : jobXpLevelFloor < 0 || jobXpLevelFloor > 9.007199254740992E15");
            jobXpNextLevelFloor = reader.ReadVaruhlong();
            if (jobXpNextLevelFloor < 0 || jobXpNextLevelFloor > 9.007199254740992E15)
                throw new Exception("Forbidden value on jobXpNextLevelFloor = " + jobXpNextLevelFloor + ", it doesn't respect the following condition : jobXpNextLevelFloor < 0 || jobXpNextLevelFloor > 9.007199254740992E15");
            

}


}


}