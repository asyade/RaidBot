


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectItemInformationWithQuantity : ObjectItemMinimalInformation
{

public const short Id = 387;
public override short TypeId
{
    get { return Id; }
}

public uint quantity;
        

public ObjectItemInformationWithQuantity()
{
}

public ObjectItemInformationWithQuantity(ushort objectGID, Types.ObjectEffect[] effects, uint quantity)
         : base(objectGID, effects)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(quantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            quantity = reader.ReadVaruhint();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}