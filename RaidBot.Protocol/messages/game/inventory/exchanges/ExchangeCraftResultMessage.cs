


















// Generated on 06/26/2015 11:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeCraftResultMessage : NetworkMessage
{

public const uint Id = 5790;
public override uint MessageId
{
    get { return Id; }
}

public sbyte craftResult;
        

public ExchangeCraftResultMessage()
{
}

public ExchangeCraftResultMessage(sbyte craftResult)
        {
            this.craftResult = craftResult;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(craftResult);
            

}

public override void Deserialize(ICustomDataReader reader)
{

craftResult = reader.ReadSByte();
            if (craftResult < 0)
                throw new Exception("Forbidden value on craftResult = " + craftResult + ", it doesn't respect the following condition : craftResult < 0");
            

}


}


}