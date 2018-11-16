


















// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class BasicStatMessage : NetworkMessage
{

public const uint Id = 6530;
public override uint MessageId
{
    get { return Id; }
}

public ushort statId;
        

public BasicStatMessage()
{
}

public BasicStatMessage(ushort statId)
        {
            this.statId = statId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(statId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

statId = reader.ReadVaruhshort();
            if (statId < 0)
                throw new Exception("Forbidden value on statId = " + statId + ", it doesn't respect the following condition : statId < 0");
            

}


}


}