


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class QuestActiveDetailedInformations : QuestActiveInformations
{

public const short Id = 382;
public override short TypeId
{
    get { return Id; }
}

public ushort stepId;
        public Types.QuestObjectiveInformations[] objectives;
        

public QuestActiveDetailedInformations()
{
}

public QuestActiveDetailedInformations(ushort questId, ushort stepId, Types.QuestObjectiveInformations[] objectives)
         : base(questId)
        {
            this.stepId = stepId;
            this.objectives = objectives;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(stepId);
            writer.WriteUShort((ushort)objectives.Length);
            foreach (var entry in objectives)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            stepId = reader.ReadVaruhshort();
            if (stepId < 0)
                throw new Exception("Forbidden value on stepId = " + stepId + ", it doesn't respect the following condition : stepId < 0");
            var limit = reader.ReadUShort();
            objectives = new Types.QuestObjectiveInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectives[i] = Types.ProtocolTypeManager.GetInstance<Types.QuestObjectiveInformations>(reader.ReadShort());
                 objectives[i].Deserialize(reader);
            }
            

}


}


}