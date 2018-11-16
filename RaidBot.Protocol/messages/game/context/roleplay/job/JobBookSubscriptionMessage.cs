


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobBookSubscriptionMessage : NetworkMessage
{

public const uint Id = 6593;
public override uint MessageId
{
    get { return Id; }
}

public bool addedOrDeleted;
        public sbyte jobId;
        

public JobBookSubscriptionMessage()
{
}

public JobBookSubscriptionMessage(bool addedOrDeleted, sbyte jobId)
        {
            this.addedOrDeleted = addedOrDeleted;
            this.jobId = jobId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(addedOrDeleted);
            writer.WriteSByte(jobId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

addedOrDeleted = reader.ReadBoolean();
            jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
            

}


}


}