


















// Generated on 06/26/2015 11:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeSetCraftRecipeMessage : NetworkMessage
{

public const uint Id = 6389;
public override uint MessageId
{
    get { return Id; }
}

public ushort objectGID;
        

public ExchangeSetCraftRecipeMessage()
{
}

public ExchangeSetCraftRecipeMessage(ushort objectGID)
        {
            this.objectGID = objectGID;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(objectGID);
            

}

public override void Deserialize(ICustomDataReader reader)
{

objectGID = reader.ReadVaruhshort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            

}


}


}