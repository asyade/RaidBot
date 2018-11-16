


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidHouseTypeMessage : NetworkMessage
{

public const uint Id = 5803;
public override uint MessageId
{
    get { return Id; }
}

public uint type;
        

public ExchangeBidHouseTypeMessage()
{
}

public ExchangeBidHouseTypeMessage(uint type)
        {
            this.type = type;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(type);
            

}

public override void Deserialize(ICustomDataReader reader)
{

type = reader.ReadVaruhint();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            

}


}


}