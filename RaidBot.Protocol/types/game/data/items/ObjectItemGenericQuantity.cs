


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectItemGenericQuantity : Item
{

public const short Id = 483;
public override short TypeId
{
    get { return Id; }
}

public ushort objectGID;
        public uint quantity;
        

public ObjectItemGenericQuantity()
{
}

public ObjectItemGenericQuantity(ushort objectGID, uint quantity)
        {
            this.objectGID = objectGID;
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(objectGID);
            writer.WriteVaruhint(quantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            objectGID = reader.ReadVaruhshort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            quantity = reader.ReadVaruhint();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}