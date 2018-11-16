


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayTaxCollectorFightRequestMessage : NetworkMessage
{

public const uint Id = 5954;
public override uint MessageId
{
    get { return Id; }
}

public int taxCollectorId;
        

public GameRolePlayTaxCollectorFightRequestMessage()
{
}

public GameRolePlayTaxCollectorFightRequestMessage(int taxCollectorId)
        {
            this.taxCollectorId = taxCollectorId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(taxCollectorId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

taxCollectorId = reader.ReadInt();
            

}


}


}