


















// Generated on 06/26/2015 11:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobCrafterDirectoryEntryRequestMessage : NetworkMessage
{

public const uint Id = 6043;
public override uint MessageId
{
    get { return Id; }
}

public uint playerId;
        

public JobCrafterDirectoryEntryRequestMessage()
{
}

public JobCrafterDirectoryEntryRequestMessage(uint playerId)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(playerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            

}


}


}