


















// Generated on 06/26/2015 11:41:15
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightJoinRequestMessage : NetworkMessage
{

public const uint Id = 701;
public override uint MessageId
{
    get { return Id; }
}

public int fighterId;
        public int fightId;
        

public GameFightJoinRequestMessage()
{
}

public GameFightJoinRequestMessage(int fighterId, int fightId)
        {
            this.fighterId = fighterId;
            this.fightId = fightId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(fighterId);
            writer.WriteInt(fightId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fighterId = reader.ReadInt();
            fightId = reader.ReadInt();
            

}


}


}