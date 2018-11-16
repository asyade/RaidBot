


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class QuestObjectiveValidationMessage : NetworkMessage
{

public const uint Id = 6085;
public override uint MessageId
{
    get { return Id; }
}

public ushort questId;
        public ushort objectiveId;
        

public QuestObjectiveValidationMessage()
{
}

public QuestObjectiveValidationMessage(ushort questId, ushort objectiveId)
        {
            this.questId = questId;
            this.objectiveId = objectiveId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(questId);
            writer.WriteVaruhshort(objectiveId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

questId = reader.ReadVaruhshort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            objectiveId = reader.ReadVaruhshort();
            if (objectiveId < 0)
                throw new Exception("Forbidden value on objectiveId = " + objectiveId + ", it doesn't respect the following condition : objectiveId < 0");
            

}


}


}