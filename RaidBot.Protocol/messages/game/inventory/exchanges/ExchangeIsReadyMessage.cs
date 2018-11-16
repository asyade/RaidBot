


















// Generated on 06/26/2015 11:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeIsReadyMessage : NetworkMessage
{

public const uint Id = 5509;
public override uint MessageId
{
    get { return Id; }
}

public uint id;
        public bool ready;
        

public ExchangeIsReadyMessage()
{
}

public ExchangeIsReadyMessage(uint id, bool ready)
        {
            this.id = id;
            this.ready = ready;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(id);
            writer.WriteBoolean(ready);
            

}

public override void Deserialize(ICustomDataReader reader)
{

id = reader.ReadVaruhint();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            ready = reader.ReadBoolean();
            

}


}


}