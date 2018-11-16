


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeObjectPutInBagMessage : ExchangeObjectMessage
{

public const uint Id = 6009;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        

public ExchangeObjectPutInBagMessage()
{
}

public ExchangeObjectPutInBagMessage(bool remote, Types.ObjectItem @object)
         : base(remote)
        {
            this.@object = @object;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            @object.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            @object = new Types.ObjectItem();
            @object.Deserialize(reader);
            

}


}


}