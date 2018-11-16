


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AccessoryPreviewMessage : NetworkMessage
{

public const uint Id = 6517;
public override uint MessageId
{
    get { return Id; }
}

public Types.EntityLook look;
        

public AccessoryPreviewMessage()
{
}

public AccessoryPreviewMessage(Types.EntityLook look)
        {
            this.look = look;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

look.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}