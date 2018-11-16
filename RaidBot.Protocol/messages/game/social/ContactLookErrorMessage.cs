


















// Generated on 06/26/2015 11:41:56
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ContactLookErrorMessage : NetworkMessage
{

public const uint Id = 6045;
public override uint MessageId
{
    get { return Id; }
}

public uint requestId;
        

public ContactLookErrorMessage()
{
}

public ContactLookErrorMessage(uint requestId)
        {
            this.requestId = requestId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(requestId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

requestId = reader.ReadVaruhint();
            if (requestId < 0)
                throw new Exception("Forbidden value on requestId = " + requestId + ", it doesn't respect the following condition : requestId < 0");
            

}


}


}