


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TaxCollectorMovementAddMessage : NetworkMessage
{

public const uint Id = 5917;
public override uint MessageId
{
    get { return Id; }
}

public Types.TaxCollectorInformations informations;
        

public TaxCollectorMovementAddMessage()
{
}

public TaxCollectorMovementAddMessage(Types.TaxCollectorInformations informations)
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

informations = Types.ProtocolTypeManager.GetInstance<Types.TaxCollectorInformations>(reader.ReadShort());
            informations.Deserialize(reader);
            

}


}


}