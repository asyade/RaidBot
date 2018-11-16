


















// Generated on 06/26/2015 11:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class WrapperObjectErrorMessage : SymbioticObjectErrorMessage
{

public const uint Id = 6529;
public override uint MessageId
{
    get { return Id; }
}



public WrapperObjectErrorMessage()
{
}

public WrapperObjectErrorMessage(sbyte reason, sbyte errorCode)
         : base(reason, errorCode)
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