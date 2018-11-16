


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InventoryPresetUpdateMessage : NetworkMessage
{

public const uint Id = 6171;
public override uint MessageId
{
    get { return Id; }
}

public Types.Preset preset;
        

public InventoryPresetUpdateMessage()
{
}

public InventoryPresetUpdateMessage(Types.Preset preset)
        {
            this.preset = preset;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

preset.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

preset = new Types.Preset();
            preset.Deserialize(reader);
            

}


}


}