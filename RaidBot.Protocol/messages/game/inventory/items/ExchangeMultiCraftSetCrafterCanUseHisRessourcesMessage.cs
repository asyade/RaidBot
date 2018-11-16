


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : NetworkMessage
{

public const uint Id = 6021;
public override uint MessageId
{
    get { return Id; }
}

public bool allow;
        

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage()
{
}

public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool allow)
        {
            this.allow = allow;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(allow);
            

}

public override void Deserialize(ICustomDataReader reader)
{

allow = reader.ReadBoolean();
            

}


}


}