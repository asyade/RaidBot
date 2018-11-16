


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class QuestStepInfoMessage : NetworkMessage
{

public const uint Id = 5625;
public override uint MessageId
{
    get { return Id; }
}

public Types.QuestActiveInformations infos;
        

public QuestStepInfoMessage()
{
}

public QuestStepInfoMessage(Types.QuestActiveInformations infos)
        {
            this.infos = infos;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

infos = Types.ProtocolTypeManager.GetInstance<Types.QuestActiveInformations>(reader.ReadShort());
            infos.Deserialize(reader);
            

}


}


}