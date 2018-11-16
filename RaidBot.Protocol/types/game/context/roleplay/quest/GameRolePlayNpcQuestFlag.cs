


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameRolePlayNpcQuestFlag
{

public const short Id = 384;
public virtual short TypeId
{
    get { return Id; }
}

public ushort[] questsToValidId;
        public ushort[] questsToStartId;
        

public GameRolePlayNpcQuestFlag()
{
}

public GameRolePlayNpcQuestFlag(ushort[] questsToValidId, ushort[] questsToStartId)
        {
            this.questsToValidId = questsToValidId;
            this.questsToStartId = questsToStartId;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)questsToValidId.Length);
            foreach (var entry in questsToValidId)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)questsToStartId.Length);
            foreach (var entry in questsToStartId)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            questsToValidId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 questsToValidId[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            questsToStartId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 questsToStartId[i] = reader.ReadVaruhshort();
            }
            

}


}


}