


















// Generated on 06/26/2015 11:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class QuestListMessage : NetworkMessage
{

public const uint Id = 5626;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] finishedQuestsIds;
        public ushort[] finishedQuestsCounts;
        public Types.QuestActiveInformations[] activeQuests;
        public ushort[] reinitDoneQuestsIds;
        

public QuestListMessage()
{
}

public QuestListMessage(ushort[] finishedQuestsIds, ushort[] finishedQuestsCounts, Types.QuestActiveInformations[] activeQuests, ushort[] reinitDoneQuestsIds)
        {
            this.finishedQuestsIds = finishedQuestsIds;
            this.finishedQuestsCounts = finishedQuestsCounts;
            this.activeQuests = activeQuests;
            this.reinitDoneQuestsIds = reinitDoneQuestsIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)finishedQuestsIds.Length);
            foreach (var entry in finishedQuestsIds)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)finishedQuestsCounts.Length);
            foreach (var entry in finishedQuestsCounts)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)activeQuests.Length);
            foreach (var entry in activeQuests)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)reinitDoneQuestsIds.Length);
            foreach (var entry in reinitDoneQuestsIds)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            finishedQuestsIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedQuestsIds[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            finishedQuestsCounts = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedQuestsCounts[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            activeQuests = new Types.QuestActiveInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 activeQuests[i] = Types.ProtocolTypeManager.GetInstance<Types.QuestActiveInformations>(reader.ReadShort());
                 activeQuests[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            reinitDoneQuestsIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 reinitDoneQuestsIds[i] = reader.ReadVaruhshort();
            }
            

}


}


}