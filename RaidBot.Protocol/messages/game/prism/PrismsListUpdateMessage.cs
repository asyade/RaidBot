


















// Generated on 06/26/2015 11:41:55
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismsListUpdateMessage : PrismsListMessage
{

public const uint Id = 6438;
public override uint MessageId
{
    get { return Id; }
}



public PrismsListUpdateMessage()
{
}

public PrismsListUpdateMessage(Types.PrismSubareaEmptyInfo[] prisms)
         : base(prisms)
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