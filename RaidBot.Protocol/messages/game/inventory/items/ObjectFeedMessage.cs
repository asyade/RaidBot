


















// Generated on 06/26/2015 11:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectFeedMessage : NetworkMessage
{

public const uint Id = 6290;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public uint foodUID;
        public uint foodQuantity;
        

public ObjectFeedMessage()
{
}

public ObjectFeedMessage(uint objectUID, uint foodUID, uint foodQuantity)
        {
            this.objectUID = objectUID;
            this.foodUID = foodUID;
            this.foodQuantity = foodQuantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(objectUID);
            writer.WriteVaruhint(foodUID);
            writer.WriteVaruhint(foodQuantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objectUID = reader.ReadVaruhint();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            foodUID = reader.ReadVaruhint();
            if (foodUID < 0)
                throw new Exception("Forbidden value on foodUID = " + foodUID + ", it doesn't respect the following condition : foodUID < 0");
            foodQuantity = reader.ReadVaruhint();
            if (foodQuantity < 0)
                throw new Exception("Forbidden value on foodQuantity = " + foodQuantity + ", it doesn't respect the following condition : foodQuantity < 0");
            

}


}


}