


















// Generated on 06/26/2015 11:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStartedWithStorageMessage : ExchangeStartedMessage
{

public const uint Id = 6236;
public override uint MessageId
{
    get { return Id; }
}

public uint storageMaxSlot;
        

public ExchangeStartedWithStorageMessage()
{
}

public ExchangeStartedWithStorageMessage(sbyte exchangeType, uint storageMaxSlot)
         : base(exchangeType)
        {
            this.storageMaxSlot = storageMaxSlot;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(storageMaxSlot);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            storageMaxSlot = reader.ReadVaruhint();
            if (storageMaxSlot < 0)
                throw new Exception("Forbidden value on storageMaxSlot = " + storageMaxSlot + ", it doesn't respect the following condition : storageMaxSlot < 0");
            

}


}


}