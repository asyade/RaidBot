


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameContextKickMessage : NetworkMessage
{

public const uint Id = 6081;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        

public GameContextKickMessage()
{
}

public GameContextKickMessage(int targetId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(targetId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

targetId = reader.ReadInt();
            

}


}


}