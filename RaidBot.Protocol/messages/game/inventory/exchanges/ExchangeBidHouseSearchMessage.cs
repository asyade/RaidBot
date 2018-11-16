


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidHouseSearchMessage : NetworkMessage
{

public const uint Id = 5806;
public override uint MessageId
{
    get { return Id; }
}

public uint type;
        public ushort genId;
        

public ExchangeBidHouseSearchMessage()
{
}

public ExchangeBidHouseSearchMessage(uint type, ushort genId)
        {
            this.type = type;
            this.genId = genId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(type);
            writer.WriteVaruhshort(genId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

type = reader.ReadVaruhint();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            genId = reader.ReadVaruhshort();
            if (genId < 0)
                throw new Exception("Forbidden value on genId = " + genId + ", it doesn't respect the following condition : genId < 0");
            

}


}


}