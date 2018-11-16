


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AreaFightModificatorUpdateMessage : NetworkMessage
{

public const uint Id = 6493;
public override uint MessageId
{
    get { return Id; }
}

public int spellPairId;
        

public AreaFightModificatorUpdateMessage()
{
}

public AreaFightModificatorUpdateMessage(int spellPairId)
        {
            this.spellPairId = spellPairId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(spellPairId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

spellPairId = reader.ReadInt();
            

}


}


}