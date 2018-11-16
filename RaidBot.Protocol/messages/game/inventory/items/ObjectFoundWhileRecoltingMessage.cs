


















// Generated on 06/26/2015 11:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectFoundWhileRecoltingMessage : NetworkMessage
{

public const uint Id = 6017;
public override uint MessageId
{
    get { return Id; }
}

public ushort genericId;
        public uint quantity;
        public uint resourceGenericId;
        

public ObjectFoundWhileRecoltingMessage()
{
}

public ObjectFoundWhileRecoltingMessage(ushort genericId, uint quantity, uint resourceGenericId)
        {
            this.genericId = genericId;
            this.quantity = quantity;
            this.resourceGenericId = resourceGenericId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(genericId);
            writer.WriteVaruhint(quantity);
            writer.WriteVaruhint(resourceGenericId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

genericId = reader.ReadVaruhshort();
            if (genericId < 0)
                throw new Exception("Forbidden value on genericId = " + genericId + ", it doesn't respect the following condition : genericId < 0");
            quantity = reader.ReadVaruhint();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            resourceGenericId = reader.ReadVaruhint();
            if (resourceGenericId < 0)
                throw new Exception("Forbidden value on resourceGenericId = " + resourceGenericId + ", it doesn't respect the following condition : resourceGenericId < 0");
            

}


}


}