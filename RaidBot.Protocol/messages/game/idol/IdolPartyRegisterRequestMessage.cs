


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IdolPartyRegisterRequestMessage : NetworkMessage
{

public const uint Id = 6582;
public override uint MessageId
{
    get { return Id; }
}

public bool register;
        

public IdolPartyRegisterRequestMessage()
{
}

public IdolPartyRegisterRequestMessage(bool register)
        {
            this.register = register;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(register);
            

}

public override void Deserialize(ICustomDataReader reader)
{

register = reader.ReadBoolean();
            

}


}


}