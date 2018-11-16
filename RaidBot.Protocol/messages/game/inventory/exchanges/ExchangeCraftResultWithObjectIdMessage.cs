


















// Generated on 06/26/2015 11:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeCraftResultWithObjectIdMessage : ExchangeCraftResultMessage
{

public const uint Id = 6000;
public override uint MessageId
{
    get { return Id; }
}

public ushort objectGenericId;
        

public ExchangeCraftResultWithObjectIdMessage()
{
}

public ExchangeCraftResultWithObjectIdMessage(sbyte craftResult, ushort objectGenericId)
         : base(craftResult)
        {
            this.objectGenericId = objectGenericId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(objectGenericId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            objectGenericId = reader.ReadVaruhshort();
            if (objectGenericId < 0)
                throw new Exception("Forbidden value on objectGenericId = " + objectGenericId + ", it doesn't respect the following condition : objectGenericId < 0");
            

}


}


}