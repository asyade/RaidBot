


















// Generated on 06/26/2015 11:41:20
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayShowActorMessage : NetworkMessage
{

public const uint Id = 5632;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameRolePlayActorInformations informations;
        

public GameRolePlayShowActorMessage()
{
}

public GameRolePlayShowActorMessage(Types.GameRolePlayActorInformations informations)
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

informations = Types.ProtocolTypeManager.GetInstance<Types.GameRolePlayActorInformations>(reader.ReadShort());
            informations.Deserialize(reader);
            

}


}


}