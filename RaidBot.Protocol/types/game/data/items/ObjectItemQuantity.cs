


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectItemQuantity : Item
{

public const short Id = 119;
public override short TypeId
{
    get { return Id; }
}

public uint objectUID;
        public uint quantity;
        

public ObjectItemQuantity()
{
}

public ObjectItemQuantity(uint objectUID, uint quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(objectUID);
            writer.WriteVaruhint(quantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            objectUID = reader.ReadVaruhint();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadVaruhint();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}