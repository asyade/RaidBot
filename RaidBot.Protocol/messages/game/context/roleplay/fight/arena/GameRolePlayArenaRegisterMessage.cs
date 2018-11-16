


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayArenaRegisterMessage : NetworkMessage
{

public const uint Id = 6280;
public override uint MessageId
{
    get { return Id; }
}

public int battleMode;
        

public GameRolePlayArenaRegisterMessage()
{
}

public GameRolePlayArenaRegisterMessage(int battleMode)
        {
            this.battleMode = battleMode;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(battleMode);
            

}

public override void Deserialize(ICustomDataReader reader)
{

battleMode = reader.ReadInt();
            if (battleMode < 0)
                throw new Exception("Forbidden value on battleMode = " + battleMode + ", it doesn't respect the following condition : battleMode < 0");
            

}


}


}