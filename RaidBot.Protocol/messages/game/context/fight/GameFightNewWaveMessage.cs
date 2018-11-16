


















// Generated on 06/26/2015 11:41:15
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightNewWaveMessage : NetworkMessage
{

public const uint Id = 6490;
public override uint MessageId
{
    get { return Id; }
}

public sbyte id;
        public sbyte teamId;
        public short nbTurnBeforeNextWave;
        

public GameFightNewWaveMessage()
{
}

public GameFightNewWaveMessage(sbyte id, sbyte teamId, short nbTurnBeforeNextWave)
        {
            this.id = id;
            this.teamId = teamId;
            this.nbTurnBeforeNextWave = nbTurnBeforeNextWave;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(id);
            writer.WriteSByte(teamId);
            writer.WriteShort(nbTurnBeforeNextWave);
            

}

public override void Deserialize(ICustomDataReader reader)
{

id = reader.ReadSByte();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            teamId = reader.ReadSByte();
            if (teamId < 0)
                throw new Exception("Forbidden value on teamId = " + teamId + ", it doesn't respect the following condition : teamId < 0");
            nbTurnBeforeNextWave = reader.ReadShort();
            

}


}


}