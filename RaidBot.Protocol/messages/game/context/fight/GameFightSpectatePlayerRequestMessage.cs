


















// Generated on 06/26/2015 11:41:17
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightSpectatePlayerRequestMessage : NetworkMessage
{

public const uint Id = 6474;
public override uint MessageId
{
    get { return Id; }
}

public int playerId;
        

public GameFightSpectatePlayerRequestMessage()
{
}

public GameFightSpectatePlayerRequestMessage(int playerId)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(playerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

playerId = reader.ReadInt();
            

}


}


}