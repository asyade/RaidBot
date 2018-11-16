


















// Generated on 06/26/2015 11:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectDeleteMessage : NetworkMessage
{

public const uint Id = 3022;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public uint quantity;
        

public ObjectDeleteMessage()
{
}

public ObjectDeleteMessage(uint objectUID, uint quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(objectUID);
            writer.WriteVaruhint(quantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objectUID = reader.ReadVaruhint();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadVaruhint();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}