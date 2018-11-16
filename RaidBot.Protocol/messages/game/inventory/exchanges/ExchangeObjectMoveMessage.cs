


















// Generated on 06/26/2015 11:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeObjectMoveMessage : NetworkMessage
{

public const uint Id = 5518;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public int quantity;
        

public ExchangeObjectMoveMessage()
{
}

public ExchangeObjectMoveMessage(uint objectUID, int quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(objectUID);
            writer.WriteVarint(quantity);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objectUID = reader.ReadVaruhint();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadVarint();
            

}


}


}