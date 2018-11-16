


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobExperienceUpdateMessage : NetworkMessage
{

public const uint Id = 5654;
public override uint MessageId
{
    get { return Id; }
}

public Types.JobExperience experiencesUpdate;
        

public JobExperienceUpdateMessage()
{
}

public JobExperienceUpdateMessage(Types.JobExperience experiencesUpdate)
        {
            this.experiencesUpdate = experiencesUpdate;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

experiencesUpdate.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

experiencesUpdate = new Types.JobExperience();
            experiencesUpdate.Deserialize(reader);
            

}


}


}