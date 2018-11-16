


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SpellForgetUIMessage : NetworkMessage
{

public const uint Id = 5565;
public override uint MessageId
{
    get { return Id; }
}

public bool open;
        

public SpellForgetUIMessage()
{
}

public SpellForgetUIMessage(bool open)
        {
            this.open = open;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(open);
            

}

public override void Deserialize(ICustomDataReader reader)
{

open = reader.ReadBoolean();
            

}


}


}