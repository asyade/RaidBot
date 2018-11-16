


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayArenaFightPropositionMessage : NetworkMessage
{

public const uint Id = 6276;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        public int[] alliesId;
        public ushort duration;
        

public GameRolePlayArenaFightPropositionMessage()
{
}

public GameRolePlayArenaFightPropositionMessage(int fightId, int[] alliesId, ushort duration)
        {
            this.fightId = fightId;
            this.alliesId = alliesId;
            this.duration = duration;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteUShort((ushort)alliesId.Length);
            foreach (var entry in alliesId)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteVaruhshort(duration);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fightId = reader.ReadInt();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            var limit = reader.ReadUShort();
            alliesId = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliesId[i] = reader.ReadInt();
            }
            duration = reader.ReadVaruhshort();
            if (duration < 0)
                throw new Exception("Forbidden value on duration = " + duration + ", it doesn't respect the following condition : duration < 0");
            

}


}


}