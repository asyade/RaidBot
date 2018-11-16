


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobCrafterDirectorySettingsMessage : NetworkMessage
{

public const uint Id = 5652;
public override uint MessageId
{
    get { return Id; }
}

public Types.JobCrafterDirectorySettings[] craftersSettings;
        

public JobCrafterDirectorySettingsMessage()
{
}

public JobCrafterDirectorySettingsMessage(Types.JobCrafterDirectorySettings[] craftersSettings)
        {
            this.craftersSettings = craftersSettings;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)craftersSettings.Length);
            foreach (var entry in craftersSettings)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            craftersSettings = new Types.JobCrafterDirectorySettings[limit];
            for (int i = 0; i < limit; i++)
            {
                 craftersSettings[i] = new Types.JobCrafterDirectorySettings();
                 craftersSettings[i].Deserialize(reader);
            }
            

}


}


}