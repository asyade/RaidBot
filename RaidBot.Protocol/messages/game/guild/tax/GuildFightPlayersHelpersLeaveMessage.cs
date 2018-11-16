


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildFightPlayersHelpersLeaveMessage : NetworkMessage
{

public const uint Id = 5719;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        public uint playerId;
        

public GuildFightPlayersHelpersLeaveMessage()
{
}

public GuildFightPlayersHelpersLeaveMessage(int fightId, uint playerId)
        {
            this.fightId = fightId;
            this.playerId = playerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteVaruhint(playerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fightId = reader.ReadInt();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            

}


}


}