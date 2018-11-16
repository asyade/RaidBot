


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TaxCollectorErrorMessage : NetworkMessage
{

public const uint Id = 5634;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public TaxCollectorErrorMessage()
{
}

public TaxCollectorErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(reason);
            

}

public override void Deserialize(ICustomDataReader reader)
{

reason = reader.ReadSByte();
            

}


}


}