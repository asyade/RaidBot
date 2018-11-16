


















// Generated on 06/26/2015 11:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChallengeFightJoinRefusedMessage : NetworkMessage
{

public const uint Id = 5908;
public override uint MessageId
{
    get { return Id; }
}

public uint playerId;
        public sbyte reason;
        

public ChallengeFightJoinRefusedMessage()
{
}

public ChallengeFightJoinRefusedMessage(uint playerId, sbyte reason)
        {
            this.playerId = playerId;
            this.reason = reason;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(playerId);
            writer.WriteSByte(reason);
            

}

public override void Deserialize(ICustomDataReader reader)
{

playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            reason = reader.ReadSByte();
            

}


}


}