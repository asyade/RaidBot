


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayAttackMonsterRequestMessage : NetworkMessage
{

public const uint Id = 6191;
public override uint MessageId
{
    get { return Id; }
}

public int monsterGroupId;
        

public GameRolePlayAttackMonsterRequestMessage()
{
}

public GameRolePlayAttackMonsterRequestMessage(int monsterGroupId)
        {
            this.monsterGroupId = monsterGroupId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(monsterGroupId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

monsterGroupId = reader.ReadInt();
            

}


}


}