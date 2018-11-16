


















// Generated on 06/26/2015 11:41:18
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightShowFighterMessage : NetworkMessage
{

public const uint Id = 5864;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations informations;
        

public GameFightShowFighterMessage()
{
}

public GameFightShowFighterMessage(Types.GameFightFighterInformations informations)
        {
            this.informations = informations;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(informations.TypeId);
            informations.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

informations = Types.ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
            informations.Deserialize(reader);
            

}


}


}