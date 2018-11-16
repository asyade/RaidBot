


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class QuestObjectiveInformations
{

public const short Id = 385;
public virtual short TypeId
{
    get { return Id; }
}

public ushort objectiveId;
        public bool objectiveStatus;
        public string[] dialogParams;
        

public QuestObjectiveInformations()
{
}

public QuestObjectiveInformations(ushort objectiveId, bool objectiveStatus, string[] dialogParams)
        {
            this.objectiveId = objectiveId;
            this.objectiveStatus = objectiveStatus;
            this.dialogParams = dialogParams;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(objectiveId);
            writer.WriteBoolean(objectiveStatus);
            writer.WriteUShort((ushort)dialogParams.Length);
            foreach (var entry in dialogParams)
            {
                 writer.WriteUTF(entry);
            }
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

objectiveId = reader.ReadVaruhshort();
            if (objectiveId < 0)
                throw new Exception("Forbidden value on objectiveId = " + objectiveId + ", it doesn't respect the following condition : objectiveId < 0");
            objectiveStatus = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            dialogParams = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 dialogParams[i] = reader.ReadUTF();
            }
            

}


}


}