


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayArenaFighterStatusMessage : NetworkMessage
{

public const uint Id = 6281;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        public int playerId;
        public bool accepted;
        

public GameRolePlayArenaFighterStatusMessage()
{
}

public GameRolePlayArenaFighterStatusMessage(int fightId, int playerId, bool accepted)
        {
            this.fightId = fightId;
            this.playerId = playerId;
            this.accepted = accepted;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteInt(playerId);
            writer.WriteBoolean(accepted);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fightId = reader.ReadInt();
            playerId = reader.ReadInt();
            accepted = reader.ReadBoolean();
            

}


}


}