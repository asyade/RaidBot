


















// Generated on 06/26/2015 11:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeCraftResultWithObjectDescMessage : ExchangeCraftResultMessage
{

public const uint Id = 5999;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItemNotInContainer objectInfo;
        

public ExchangeCraftResultWithObjectDescMessage()
{
}

public ExchangeCraftResultWithObjectDescMessage(sbyte craftResult, Types.ObjectItemNotInContainer objectInfo)
         : base(craftResult)
        {
            this.objectInfo = objectInfo;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            objectInfo.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            objectInfo = new Types.ObjectItemNotInContainer();
            objectInfo.Deserialize(reader);
            

}


}


}