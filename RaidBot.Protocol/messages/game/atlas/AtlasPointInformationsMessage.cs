


















// Generated on 06/26/2015 11:41:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AtlasPointInformationsMessage : NetworkMessage
{

public const uint Id = 5956;
public override uint MessageId
{
    get { return Id; }
}

public Types.AtlasPointsInformations type;
        

public AtlasPointInformationsMessage()
{
}

public AtlasPointInformationsMessage(Types.AtlasPointsInformations type)
        {
            this.type = type;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

type.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

type = new Types.AtlasPointsInformations();
            type.Deserialize(reader);
            

}


}


}