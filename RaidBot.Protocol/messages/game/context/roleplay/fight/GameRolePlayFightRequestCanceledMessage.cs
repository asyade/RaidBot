


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayFightRequestCanceledMessage : NetworkMessage
{

public const uint Id = 5822;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        public uint sourceId;
        public int targetId;
        

public GameRolePlayFightRequestCanceledMessage()
{
}

public GameRolePlayFightRequestCanceledMessage(int fightId, uint sourceId, int targetId)
        {
            this.fightId = fightId;
            this.sourceId = sourceId;
            this.targetId = targetId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteVaruhint(sourceId);
            writer.WriteInt(targetId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fightId = reader.ReadInt();
            sourceId = reader.ReadVaruhint();
            if (sourceId < 0)
                throw new Exception("Forbidden value on sourceId = " + sourceId + ", it doesn't respect the following condition : sourceId < 0");
            targetId = reader.ReadInt();
            

}


}


}