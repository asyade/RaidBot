


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeBidHouseGenericItemRemovedMessage : NetworkMessage
{

public const uint Id = 5948;
public override uint MessageId
{
    get { return Id; }
}

public ushort objGenericId;
        

public ExchangeBidHouseGenericItemRemovedMessage()
{
}

public ExchangeBidHouseGenericItemRemovedMessage(ushort objGenericId)
        {
            this.objGenericId = objGenericId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(objGenericId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objGenericId = reader.ReadVaruhshort();
            if (objGenericId < 0)
                throw new Exception("Forbidden value on objGenericId = " + objGenericId + ", it doesn't respect the following condition : objGenericId < 0");
            

}


}


}