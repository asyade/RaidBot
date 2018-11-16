


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStoppedMessage : NetworkMessage
{

public const uint Id = 6589;
public override uint MessageId
{
    get { return Id; }
}

public uint id;
        

public ExchangeStoppedMessage()
{
}

public ExchangeStoppedMessage(uint id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(id);
            

}

public override void Deserialize(ICustomDataReader reader)
{

id = reader.ReadVaruhint();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}