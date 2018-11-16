


















// Generated on 06/26/2015 11:41:20
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PaddockBuyRequestMessage : NetworkMessage
{

public const uint Id = 5951;
public override uint MessageId
{
    get { return Id; }
}

public uint proposedPrice;
        

public PaddockBuyRequestMessage()
{
}

public PaddockBuyRequestMessage(uint proposedPrice)
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