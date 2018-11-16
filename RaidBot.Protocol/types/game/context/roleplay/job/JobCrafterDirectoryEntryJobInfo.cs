


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class JobCrafterDirectoryEntryJobInfo
{

public const short Id = 195;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte jobId;
        public byte jobLevel;
        public bool free;
        public byte minLevel;
        

public JobCrafterDirectoryEntryJobInfo()
{
}

public JobCrafterDirectoryEntryJobInfo(sbyte jobId, byte jobLevel, bool free, byte minLevel)
        {
            this.jobId = jobId;
            this.jobLevel = jobLevel;
            this.free = free;
            this.minLevel = minLevel;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(jobId);
            writer.WriteByte(jobLevel);
            writer.WriteBoolean(free);
            writer.WriteByte(minLevel);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
            jobLevel = reader.ReadByte();
            if (jobLevel < 1 || jobLevel > 200)
                throw new Exception("Forbidden value on jobLevel = " + jobLevel + ", it doesn't respect the following condition : jobLevel < 1 || jobLevel > 200");
            free = reader.ReadBoolean();
            minLevel = reader.ReadByte();
            if (minLevel < 0 || minLevel > 255)
                throw new Exception("Forbidden value on minLevel = " + minLevel + ", it doesn't respect the following condition : minLevel < 0 || minLevel > 255");
            

}


}


}