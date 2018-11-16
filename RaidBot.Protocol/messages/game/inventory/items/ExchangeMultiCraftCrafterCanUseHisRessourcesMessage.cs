


















// Generated on 06/26/2015 11:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage : NetworkMessage
{

public const uint Id = 6020;
public override uint MessageId
{
    get { return Id; }
}

public bool allowed;
        

public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage()
{
}

public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage(bool allowed)
        {
            this.allowed = allowed;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(allowed);
            

}

public override void Deserialize(ICustomDataReader reader)
{

allowed = reader.ReadBoolean();
            

}


}


}