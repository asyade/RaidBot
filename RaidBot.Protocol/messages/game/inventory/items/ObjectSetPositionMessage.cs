


















// Generated on 06/26/2015 11:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectSetPositionMessage : NetworkMessage
{

public const uint Id = 3021;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public byte position;
        public uint quantity;
        

public ObjectSetPositionMessage()
{
}

public ObjectSetPositionMessage(uint objectUID, byte position, uint quantity)
        {
            this.objectUID = objectUID;
            this.position = position;
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(objectUID);
            writer.WriteByte(position);
            writer.WriteVaruhint(quantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objectUID = reader.ReadVaruhint();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            position = reader.ReadByte();
            if (position < 0 || position > 255)
                throw new Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 255");
            quantity = reader.ReadVaruhint();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}