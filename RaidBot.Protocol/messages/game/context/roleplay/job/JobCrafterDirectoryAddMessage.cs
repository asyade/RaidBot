


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobCrafterDirectoryAddMessage : NetworkMessage
{

public const uint Id = 5651;
public override uint MessageId
{
    get { return Id; }
}

public Types.JobCrafterDirectoryListEntry listEntry;
        

public JobCrafterDirectoryAddMessage()
{
}

public JobCrafterDirectoryAddMessage(Types.JobCrafterDirectoryListEntry listEntry)
        {
            this.listEntry = listEntry;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

listEntry.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

listEntry = new Types.JobCrafterDirectoryListEntry();
            listEntry.Deserialize(reader);
            

}


}


}