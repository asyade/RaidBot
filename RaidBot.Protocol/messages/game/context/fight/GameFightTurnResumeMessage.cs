


















// Generated on 06/26/2015 11:41:17
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightTurnResumeMessage : GameFightTurnStartMessage
{

public const uint Id = 6307;
public override uint MessageId
{
    get { return Id; }
}

public uint remainingTime;
        

public GameFightTurnResumeMessage()
{
}

public GameFightTurnResumeMessage(int id, uint waitTime, uint remainingTime)
         : base(id, waitTime)
        {
            this.remainingTime = remainingTime;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(remainingTime);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            remainingTime = reader.ReadVaruhint();
            if (remainingTime < 0)
                throw new Exception("Forbidden value on remainingTime = " + remainingTime + ", it doesn't respect the following condition : remainingTime < 0");
            

}


}


}