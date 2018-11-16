


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PaddockPropertiesMessage : NetworkMessage
{

public const uint Id = 5824;
public override uint MessageId
{
    get { return Id; }
}

public Types.PaddockInformations properties;
        

public PaddockPropertiesMessage()
{
}

public PaddockPropertiesMessage(Types.PaddockInformations properties)
        {
            this.properties = properties;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(properties.TypeId);
            properties.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

properties = Types.ProtocolTypeManager.GetInstance<Types.PaddockInformations>(reader.ReadShort());
            properties.Deserialize(reader);
            

}


}


}