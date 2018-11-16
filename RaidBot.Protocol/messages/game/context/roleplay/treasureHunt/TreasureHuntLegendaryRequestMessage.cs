


















// Generated on 06/26/2015 11:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TreasureHuntLegendaryRequestMessage : NetworkMessage
{

public const uint Id = 6499;
public override uint MessageId
{
    get { return Id; }
}

public ushort legendaryId;
        

public TreasureHuntLegendaryRequestMessage()
{
}

public TreasureHuntLegendaryRequestMessage(ushort legendaryId)
        {
            this.legendaryId = legendaryId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(legendaryId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

legendaryId = reader.ReadVaruhshort();
            if (legendaryId < 0)
                throw new Exception("Forbidden value on legendaryId = " + legendaryId + ", it doesn't respect the following condition : legendaryId < 0");
            

}


}


}