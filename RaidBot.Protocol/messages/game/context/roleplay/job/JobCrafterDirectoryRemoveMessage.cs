


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobCrafterDirectoryRemoveMessage : NetworkMessage
{

public const uint Id = 5653;
public override uint MessageId
{
    get { return Id; }
}

public sbyte jobId;
        public uint playerId;
        

public JobCrafterDirectoryRemoveMessage()
{
}

public JobCrafterDirectoryRemoveMessage(sbyte jobId, uint playerId)
        {
            this.jobId = jobId;
            this.playerId = playerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(jobId);
            writer.WriteVaruhint(playerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

jobId = reader.ReadSByte();
            if (jobId < 0)
                throw new Exception("Forbidden value on jobId = " + jobId + ", it doesn't respect the following condition : jobId < 0");
            playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            

}


}


}