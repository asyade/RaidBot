


















// Generated on 06/26/2015 11:41:16
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightRemoveTeamMemberMessage : NetworkMessage
{

public const uint Id = 711;
public override uint MessageId
{
    get { return Id; }
}

public short fightId;
        public sbyte teamId;
        public int charId;
        

public GameFightRemoveTeamMemberMessage()
{
}

public GameFightRemoveTeamMemberMessage(short fightId, sbyte teamId, int charId)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.charId = charId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(fightId);
            writer.WriteSByte(teamId);
            writer.WriteInt(charId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fightId = reader.ReadShort();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            teamId = reader.ReadSByte();
            if (teamId < 0)
                throw new Exception("Forbidden value on teamId = " + teamId + ", it doesn't respect the following condition : teamId < 0");
            charId = reader.ReadInt();
            

}


}


}