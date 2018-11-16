


















// Generated on 06/26/2015 11:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObtainedItemMessage : NetworkMessage
{

public const uint Id = 6519;
public override uint MessageId
{
    get { return Id; }
}

public ushort genericId;
        public uint baseQuantity;
        

public ObtainedItemMessage()
{
}

public ObtainedItemMessage(ushort genericId, uint baseQuantity)
        {
            this.genericId = genericId;
            this.baseQuantity = baseQuantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(genericId);
            writer.WriteVaruhint(baseQuantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

genericId = reader.ReadVaruhshort();
            if (genericId < 0)
                throw new Exception("Forbidden value on genericId = " + genericId + ", it doesn't respect the following condition : genericId < 0");
            baseQuantity = reader.ReadVaruhint();
            if (baseQuantity < 0)
                throw new Exception("Forbidden value on baseQuantity = " + baseQuantity + ", it doesn't respect the following condition : baseQuantity < 0");
            

}


}


}