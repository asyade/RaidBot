


















// Generated on 06/26/2015 11:41:24
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HouseSellFromInsideRequestMessage : HouseSellRequestMessage
{

public const uint Id = 5884;
public override uint MessageId
{
    get { return Id; }
}



public HouseSellFromInsideRequestMessage()
{
}

public HouseSellFromInsideRequestMessage(uint amount)
         : base(amount)
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