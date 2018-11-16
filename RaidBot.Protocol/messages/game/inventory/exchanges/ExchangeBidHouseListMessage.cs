


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidHouseListMessage : NetworkMessage
{

public const uint Id = 5807;
public override uint MessageId
{
    get { return Id; }
}

public ushort id;
        

public ExchangeBidHouseListMessage()
{
}

public ExchangeBidHouseListMessage(ushort id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(id);
            

}

public override void Deserialize(ICustomDataReader reader)
{

id = reader.ReadVaruhshort();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}