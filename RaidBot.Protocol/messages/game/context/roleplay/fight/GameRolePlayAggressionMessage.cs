


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayAggressionMessage : NetworkMessage
{

public const uint Id = 6073;
public override uint MessageId
{
    get { return Id; }
}

public uint attackerId;
        public uint defenderId;
        

public GameRolePlayAggressionMessage()
{
}

public GameRolePlayAggressionMessage(uint attackerId, uint defenderId)
        {
            this.attackerId = attackerId;
            this.defenderId = defenderId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(attackerId);
            writer.WriteVaruhint(defenderId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

attackerId = reader.ReadVaruhint();
            if (attackerId < 0)
                throw new Exception("Forbidden value on attackerId = " + attackerId + ", it doesn't respect the following condition : attackerId < 0");
            defenderId = reader.ReadVaruhint();
            if (defenderId < 0)
                throw new Exception("Forbidden value on defenderId = " + defenderId + ", it doesn't respect the following condition : defenderId < 0");
            

}


}


}