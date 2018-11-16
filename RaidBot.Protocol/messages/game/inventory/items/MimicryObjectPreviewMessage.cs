


















// Generated on 06/26/2015 11:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MimicryObjectPreviewMessage : NetworkMessage
{

public const uint Id = 6458;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem result;
        

public MimicryObjectPreviewMessage()
{
}

public MimicryObjectPreviewMessage(Types.ObjectItem result)
        {
            this.result = result;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

result.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

result = new Types.ObjectItem();
            result.Deserialize(reader);
            

}


}


}