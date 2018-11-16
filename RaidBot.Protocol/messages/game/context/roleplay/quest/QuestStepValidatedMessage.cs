


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class QuestStepValidatedMessage : NetworkMessage
{

public const uint Id = 6099;
public override uint MessageId
{
    get { return Id; }
}

public ushort questId;
        public ushort stepId;
        

public QuestStepValidatedMessage()
{
}

public QuestStepValidatedMessage(ushort questId, ushort stepId)
        {
            this.questId = questId;
            this.stepId = stepId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(questId);
            writer.WriteVaruhshort(stepId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

questId = reader.ReadVaruhshort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            stepId = reader.ReadVaruhshort();
            if (stepId < 0)
                throw new Exception("Forbidden value on stepId = " + stepId + ", it doesn't respect the following condition : stepId < 0");
            

}


}


}