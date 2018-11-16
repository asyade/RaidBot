


















// Generated on 06/26/2015 11:41:21
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MapRunningFightDetailsRequestMessage : NetworkMessage
{

public const uint Id = 5750;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        

public MapRunningFightDetailsRequestMessage()
{
}

public MapRunningFightDetailsRequestMessage(int fightId)
        {
            this.fightId = fightId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(fightId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fightId = reader.ReadInt();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            

}


}


}