


















// Generated on 06/26/2015 11:41:24
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HousePropertiesMessage : NetworkMessage
{

public const uint Id = 5734;
public override uint MessageId
{
    get { return Id; }
}

public Types.HouseInformations properties;
        

public HousePropertiesMessage()
{
}

public HousePropertiesMessage(Types.HouseInformations properties)
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

properties = Types.ProtocolTypeManager.GetInstance<Types.HouseInformations>(reader.ReadShort());
            properties.Deserialize(reader);
            

}


}


}