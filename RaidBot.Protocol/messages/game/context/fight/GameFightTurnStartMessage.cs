


















// Generated on 06/26/2015 11:41:17
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightTurnStartMessage : NetworkMessage
{

public const uint Id = 714;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        public uint waitTime;
        

public GameFightTurnStartMessage()
{
}

public GameFightTurnStartMessage(int id, uint waitTime)
        {
            this.id = id;
            this.waitTime = waitTime;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(id);
            writer.WriteVaruhint(waitTime);
            

}

public override void Deserialize(ICustomDataReader reader)
{

id = reader.ReadInt();
            waitTime = reader.ReadVaruhint();
            if (waitTime < 0)
                throw new Exception("Forbidden value on waitTime = " + waitTime + ", it doesn't respect the following condition : waitTime < 0");
            

}


}


}