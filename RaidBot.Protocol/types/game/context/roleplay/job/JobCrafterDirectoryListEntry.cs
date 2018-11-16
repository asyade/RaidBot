


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class JobCrafterDirectoryListEntry
{

public const short Id = 196;
public virtual short TypeId
{
    get { return Id; }
}

public Types.JobCrafterDirectoryEntryPlayerInfo playerInfo;
        public Types.JobCrafterDirectoryEntryJobInfo jobInfo;
        

public JobCrafterDirectoryListEntry()
{
}

public JobCrafterDirectoryListEntry(Types.JobCrafterDirectoryEntryPlayerInfo playerInfo, Types.JobCrafterDirectoryEntryJobInfo jobInfo)
        {
            this.playerInfo = playerInfo;
            this.jobInfo = jobInfo;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

playerInfo.Serialize(writer);
            jobInfo.Serialize(writer);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

playerInfo = new Types.JobCrafterDirectoryEntryPlayerInfo();
            playerInfo.Deserialize(reader);
            jobInfo = new Types.JobCrafterDirectoryEntryJobInfo();
            jobInfo.Deserialize(reader);
            

}


}


}