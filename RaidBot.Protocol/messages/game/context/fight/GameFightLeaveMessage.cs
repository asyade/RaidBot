


















// Generated on 06/26/2015 11:41:15
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightLeaveMessage : NetworkMessage
{

public const uint Id = 721;
public override uint MessageId
{
    get { return Id; }
}

public int charId;
        

public GameFightLeaveMessage()
{
}

public GameFightLeaveMessage(int charId)
        {
            this.charId = charId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(charId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

charId = reader.ReadInt();
            

}


}


}