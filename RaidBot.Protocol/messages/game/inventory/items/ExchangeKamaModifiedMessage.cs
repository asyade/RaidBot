


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeKamaModifiedMessage : ExchangeObjectMessage
{

public const uint Id = 5521;
public override uint MessageId
{
    get { return Id; }
}

public uint quantity;
        

public ExchangeKamaModifiedMessage()
{
}

public ExchangeKamaModifiedMessage(bool remote, uint quantity)
         : base(remote)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(quantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            quantity = reader.ReadVaruhint();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}