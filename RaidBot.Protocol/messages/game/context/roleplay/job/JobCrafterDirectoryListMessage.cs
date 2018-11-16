


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobCrafterDirectoryListMessage : NetworkMessage
{

public const uint Id = 6046;
public override uint MessageId
{
    get { return Id; }
}

public Types.JobCrafterDirectoryListEntry[] listEntries;
        

public JobCrafterDirectoryListMessage()
{
}

public JobCrafterDirectoryListMessage(Types.JobCrafterDirectoryListEntry[] listEntries)
        {
            this.listEntries = listEntries;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)listEntries.Length);
            foreach (var entry in listEntries)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            listEntries = new Types.JobCrafterDirectoryListEntry[limit];
            for (int i = 0; i < limit; i++)
            {
                 listEntries[i] = new Types.JobCrafterDirectoryListEntry();
                 listEntries[i].Deserialize(reader);
            }
            

}


}


}