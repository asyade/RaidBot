


















// Generated on 06/26/2015 11:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class WrapperObjectAssociatedMessage : SymbioticObjectAssociatedMessage
{

public const uint Id = 6523;
public override uint MessageId
{
    get { return Id; }
}



public WrapperObjectAssociatedMessage()
{
}

public WrapperObjectAssociatedMessage(uint hostUID)
         : base(hostUID)
        {
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            

}


}


}