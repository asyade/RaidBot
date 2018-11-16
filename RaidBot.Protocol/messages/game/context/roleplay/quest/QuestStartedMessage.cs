


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class QuestStartedMessage : NetworkMessage
{

public const uint Id = 6091;
public override uint MessageId
{
    get { return Id; }
}

public ushort questId;
        

public QuestStartedMessage()
{
}

public QuestStartedMessage(ushort questId)
        {
            this.questId = questId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(questId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

questId = reader.ReadVaruhshort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            

}


}


}