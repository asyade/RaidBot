


















// Generated on 06/26/2015 11:41:17
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightStartingMessage : NetworkMessage
{

public const uint Id = 700;
public override uint MessageId
{
    get { return Id; }
}

public sbyte fightType;
        public int attackerId;
        public int defenderId;
        

public GameFightStartingMessage()
{
}

public GameFightStartingMessage(sbyte fightType, int attackerId, int defenderId)
        {
            this.fightType = fightType;
            this.attackerId = attackerId;
            this.defenderId = defenderId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(fightType);
            writer.WriteInt(attackerId);
            writer.WriteInt(defenderId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fightType = reader.ReadSByte();
            if (fightType < 0)
                throw new Exception("Forbidden value on fightType = " + fightType + ", it doesn't respect the following condition : fightType < 0");
            attackerId = reader.ReadInt();
            defenderId = reader.ReadInt();
            

}


}


}