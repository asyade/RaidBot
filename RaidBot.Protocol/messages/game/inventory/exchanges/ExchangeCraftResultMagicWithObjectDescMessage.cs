


















// Generated on 06/26/2015 11:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeCraftResultMagicWithObjectDescMessage : ExchangeCraftResultWithObjectDescMessage
{

public const uint Id = 6188;
public override uint MessageId
{
    get { return Id; }
}

public sbyte magicPoolStatus;
        

public ExchangeCraftResultMagicWithObjectDescMessage()
{
}

public ExchangeCraftResultMagicWithObjectDescMessage(sbyte craftResult, Types.ObjectItemNotInContainer objectInfo, sbyte magicPoolStatus)
         : base(craftResult, objectInfo)
        {
            this.magicPoolStatus = magicPoolStatus;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(magicPoolStatus);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            magicPoolStatus = reader.ReadSByte();
            

}


}


}