


















// Generated on 06/26/2015 11:41:24
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HouseSellRequestMessage : NetworkMessage
{

public const uint Id = 5697;
public override uint MessageId
{
    get { return Id; }
}

public uint amount;
        

public HouseSellRequestMessage()
{
}

public HouseSellRequestMessage(uint amount)
        {
            this.amount = amount;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(amount);
            

}

public override void Deserialize(ICustomDataReader reader)
{

amount = reader.ReadVaruhint();
            if (amount < 0)
                throw new Exception("Forbidden value on amount = " + amount + ", it doesn't respect the following condition : amount < 0");
            

}


}


}