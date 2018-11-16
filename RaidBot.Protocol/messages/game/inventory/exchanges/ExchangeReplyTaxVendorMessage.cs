


















// Generated on 06/26/2015 11:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeReplyTaxVendorMessage : NetworkMessage
{

public const uint Id = 5787;
public override uint MessageId
{
    get { return Id; }
}

public uint objectValue;
        public uint totalTaxValue;
        

public ExchangeReplyTaxVendorMessage()
{
}

public ExchangeReplyTaxVendorMessage(uint objectValue, uint totalTaxValue)
        {
            this.objectValue = objectValue;
            this.totalTaxValue = totalTaxValue;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(objectValue);
            writer.WriteVaruhint(totalTaxValue);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objectValue = reader.ReadVaruhint();
            if (objectValue < 0)
                throw new Exception("Forbidden value on objectValue = " + objectValue + ", it doesn't respect the following condition : objectValue < 0");
            totalTaxValue = reader.ReadVaruhint();
            if (totalTaxValue < 0)
                throw new Exception("Forbidden value on totalTaxValue = " + totalTaxValue + ", it doesn't respect the following condition : totalTaxValue < 0");
            

}


}


}