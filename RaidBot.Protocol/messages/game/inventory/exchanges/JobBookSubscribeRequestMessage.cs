


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobBookSubscribeRequestMessage : NetworkMessage
{

public const uint Id = 6592;
public override uint MessageId
{
    get { return Id; }
}

public sbyte jobId;
        

public JobBookSubscribeRequestMessage()
{
}

public JobBookSubscribeRequestMessage(sbyte jobId)
        {
            this.jobId = jobId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(jobId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
            

}


}


}