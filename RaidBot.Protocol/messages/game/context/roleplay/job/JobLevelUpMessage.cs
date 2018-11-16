


















// Generated on 06/26/2015 11:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobLevelUpMessage : NetworkMessage
{

public const uint Id = 5656;
public override uint MessageId
{
    get { return Id; }
}

public byte newLevel;
        public Types.JobDescription jobsDescription;
        

public JobLevelUpMessage()
{
}

public JobLevelUpMessage(byte newLevel, Types.JobDescription jobsDescription)
        {
            this.newLevel = newLevel;
            this.jobsDescription = jobsDescription;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteByte(newLevel);
            jobsDescription.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

newLevel = reader.ReadByte();
            if (newLevel < 0 || newLevel > 255)
                throw new Exception("Forbidden value on newLevel = " + newLevel + ", it doesn't respect the following condition : newLevel < 0 || newLevel > 255");
            jobsDescription = new Types.JobDescription();
            jobsDescription.Deserialize(reader);
            

}


}


}