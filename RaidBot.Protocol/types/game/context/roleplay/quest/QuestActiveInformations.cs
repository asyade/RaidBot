


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class QuestActiveInformations
{

public const short Id = 381;
public virtual short TypeId
{
    get { return Id; }
}

public ushort questId;
        

public QuestActiveInformations()
{
}

public QuestActiveInformations(ushort questId)
        {
            this.questId = questId;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(questId);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

questId = reader.ReadVaruhshort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            

}


}


}