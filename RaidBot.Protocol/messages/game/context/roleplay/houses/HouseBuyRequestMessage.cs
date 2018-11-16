


















// Generated on 06/26/2015 11:41:24
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HouseBuyRequestMessage : NetworkMessage
{

public const uint Id = 5738;
public override uint MessageId
{
    get { return Id; }
}

public uint proposedPrice;
        

public HouseBuyRequestMessage()
{
}

public HouseBuyRequestMessage(uint proposedPrice)
        {
            this.proposedPrice = proposedPrice;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(proposedPrice);
            

}

public override void Deserialize(ICustomDataReader reader)
{

proposedPrice = reader.ReadVaruhint();
            if (proposedPrice < 0)
                throw new Exception("Forbidden value on proposedPrice = " + proposedPrice + ", it doesn't respect the following condition : proposedPrice < 0");
            

}


}


}