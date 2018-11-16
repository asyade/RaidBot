


















// Generated on 06/26/2015 11:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeReadyMessage : NetworkMessage
{

public const uint Id = 5511;
public override uint MessageId
{
    get { return Id; }
}

public bool ready;
        public ushort step;
        

public ExchangeReadyMessage()
{
}

public ExchangeReadyMessage(bool ready, ushort step)
        {
            this.ready = ready;
            this.step = step;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(ready);
            writer.WriteVaruhshort(step);
            

}

public override void Deserialize(ICustomDataReader reader)
{

ready = reader.ReadBoolean();
            step = reader.ReadVaruhshort();
            if (step < 0)
                throw new Exception("Forbidden value on step = " + step + ", it doesn't respect the following condition : step < 0");
            

}


}


}