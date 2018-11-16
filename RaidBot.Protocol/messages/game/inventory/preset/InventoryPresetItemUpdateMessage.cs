


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InventoryPresetItemUpdateMessage : NetworkMessage
{

public const uint Id = 6168;
public override uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public Types.PresetItem presetItem;
        

public InventoryPresetItemUpdateMessage()
{
}

public InventoryPresetItemUpdateMessage(sbyte presetId, Types.PresetItem presetItem)
        {
            this.presetId = presetId;
            this.presetItem = presetItem;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(presetId);
            presetItem.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            presetItem = new Types.PresetItem();
            presetItem.Deserialize(reader);
            

}


}


}