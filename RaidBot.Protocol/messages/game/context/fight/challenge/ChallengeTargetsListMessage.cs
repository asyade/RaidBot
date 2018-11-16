


















// Generated on 06/26/2015 11:41:18
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ChallengeTargetsListMessage : NetworkMessage
{

public const uint Id = 5613;
public override uint MessageId
{
    get { return Id; }
}

public int[] targetIds;
        public short[] targetCells;
        

public ChallengeTargetsListMessage()
{
}

public ChallengeTargetsListMessage(int[] targetIds, short[] targetCells)
        {
            this.targetIds = targetIds;
            this.targetCells = targetCells;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)targetIds.Length);
            foreach (var entry in targetIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteUShort((ushort)targetCells.Length);
            foreach (var entry in targetCells)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            targetIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 targetIds[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            targetCells = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 targetCells[i] = reader.ReadShort();
            }
            

}


}


}