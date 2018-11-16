


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayPlayerFightFriendlyAnsweredMessage : NetworkMessage
{

public const uint Id = 5733;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        public uint sourceId;
        public uint targetId;
        public bool accept;
        

public GameRolePlayPlayerFightFriendlyAnsweredMessage()
{
}

public GameRolePlayPlayerFightFriendlyAnsweredMessage(int fightId, uint sourceId, uint targetId, bool accept)
        {
            this.fightId = fightId;
            this.sourceId = sourceId;
            this.targetId = targetId;
            this.accept = accept;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteVaruhint(sourceId);
            writer.WriteVaruhint(targetId);
            writer.WriteBoolean(accept);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fightId = reader.ReadInt();
            sourceId = reader.ReadVaruhint();
            if (sourceId < 0)
                throw new Exception("Forbidden value on sourceId = " + sourceId + ", it doesn't respect the following condition : sourceId < 0");
            targetId = reader.ReadVaruhint();
            if (targetId < 0)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < 0");
            accept = reader.ReadBoolean();
            

}


}


}