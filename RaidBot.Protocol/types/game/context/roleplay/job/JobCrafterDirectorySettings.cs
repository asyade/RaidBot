


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class JobCrafterDirectorySettings
{

public const short Id = 97;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte jobId;
        public byte minLevel;
        public bool free;
        

public JobCrafterDirectorySettings()
{
}

public JobCrafterDirectorySettings(sbyte jobId, byte minLevel, bool free)
        {
            this.jobId = jobId;
            this.minLevel = minLevel;
            this.free = free;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(jobId);
            writer.WriteByte(minLevel);
            writer.WriteBoolean(free);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
            minLevel = reader.ReadByte();
            if (minLevel < 0 || minLevel > 255)
                throw new Exception("Forbidden value on minLevel = " + minLevel + ", it doesn't respect the following condition : minLevel < 0 || minLevel > 255");
            free = reader.ReadBoolean();
            

}


}


}