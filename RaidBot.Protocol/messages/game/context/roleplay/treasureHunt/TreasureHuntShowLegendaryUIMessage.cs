


















// Generated on 06/26/2015 11:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TreasureHuntShowLegendaryUIMessage : NetworkMessage
{

public const uint Id = 6498;
public override uint MessageId
{
    get { return Id; }
}

public ushort[] availableLegendaryIds;
        

public TreasureHuntShowLegendaryUIMessage()
{
}

public TreasureHuntShowLegendaryUIMessage(ushort[] availableLegendaryIds)
        {
            this.availableLegendaryIds = availableLegendaryIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)availableLegendaryIds.Length);
            foreach (var entry in availableLegendaryIds)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            availableLegendaryIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 availableLegendaryIds[i] = reader.ReadVaruhshort();
            }
            

}


}


}