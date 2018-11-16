


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayPlayerFightFriendlyAnswerMessage : NetworkMessage
{

public const uint Id = 5732;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        public bool accept;
        

public GameRolePlayPlayerFightFriendlyAnswerMessage()
{
}

public GameRolePlayPlayerFightFriendlyAnswerMessage(int fightId, bool accept)
        {
            this.fightId = fightId;
            this.accept = accept;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteBoolean(accept);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fightId = reader.ReadInt();
            accept = reader.ReadBoolean();
            

}


}


}