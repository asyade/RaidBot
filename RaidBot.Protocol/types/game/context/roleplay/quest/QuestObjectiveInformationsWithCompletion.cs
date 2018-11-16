


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class QuestObjectiveInformationsWithCompletion : QuestObjectiveInformations
{

public const short Id = 386;
public override short TypeId
{
    get { return Id; }
}

public ushort curCompletion;
        public ushort maxCompletion;
        

public QuestObjectiveInformationsWithCompletion()
{
}

public QuestObjectiveInformationsWithCompletion(ushort objectiveId, bool objectiveStatus, string[] dialogParams, ushort curCompletion, ushort maxCompletion)
         : base(objectiveId, objectiveStatus, dialogParams)
        {
            this.curCompletion = curCompletion;
            this.maxCompletion = maxCompletion;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(curCompletion);
            writer.WriteVaruhshort(maxCompletion);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            curCompletion = reader.ReadVaruhshort();
            if (curCompletion < 0)
                throw new Exception("Forbidden value on curCompletion = " + curCompletion + ", it doesn't respect the following condition : curCompletion < 0");
            maxCompletion = reader.ReadVaruhshort();
            if (maxCompletion < 0)
                throw new Exception("Forbidden value on maxCompletion = " + maxCompletion + ", it doesn't respect the following condition : maxCompletion < 0");
            

}


}


}