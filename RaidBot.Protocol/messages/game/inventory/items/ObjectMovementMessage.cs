


















// Generated on 06/26/2015 11:41:51
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectMovementMessage : NetworkMessage
{

public const uint Id = 3010;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public byte position;
        

public ObjectMovementMessage()
{
}

public ObjectMovementMessage(uint objectUID, byte position)
        {
            this.objectUID = objectUID;
            this.position = position;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(objectUID);
            writer.WriteByte(position);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objectUID = reader.ReadVaruhint();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            position = reader.ReadByte();
            if (position < 0 || position > 255)
                throw new Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 255");
            

}


}


}