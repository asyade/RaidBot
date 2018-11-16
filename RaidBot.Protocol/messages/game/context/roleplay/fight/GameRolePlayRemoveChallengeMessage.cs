


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayRemoveChallengeMessage : NetworkMessage
{

public const uint Id = 300;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        

public GameRolePlayRemoveChallengeMessage()
{
}

public GameRolePlayRemoveChallengeMessage(int fightId)
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
            

}


}


}