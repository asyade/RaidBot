


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobCrafterDirectoryDefineSettingsMessage : NetworkMessage
{

public const uint Id = 5649;
public override uint MessageId
{
    get { return Id; }
}

public Types.JobCrafterDirectorySettings settings;
        

public JobCrafterDirectoryDefineSettingsMessage()
{
}

public JobCrafterDirectoryDefineSettingsMessage(Types.JobCrafterDirectorySettings settings)
        {
            this.settings = settings;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

settings.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

settings = new Types.JobCrafterDirectorySettings();
            settings.Deserialize(reader);
            

}


}


}