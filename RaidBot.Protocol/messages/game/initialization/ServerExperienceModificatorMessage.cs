


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ServerExperienceModificatorMessage : NetworkMessage
{

public const uint Id = 6237;
public override uint MessageId
{
    get { return Id; }
}

public ushort experiencePercent;
        

public ServerExperienceModificatorMessage()
{
}

public ServerExperienceModificatorMessage(ushort experiencePercent)
        {
            this.experiencePercent = experiencePercent;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(experiencePercent);
            

}

public override void Deserialize(ICustomDataReader reader)
{

experiencePercent = reader.ReadVaruhshort();
            if (experiencePercent < 0)
                throw new Exception("Forbidden value on experiencePercent = " + experiencePercent + ", it doesn't respect the following condition : experiencePercent < 0");
            

}


}


}