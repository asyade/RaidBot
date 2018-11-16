


















// Generated on 06/26/2015 11:41:50
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InventoryContentAndPresetMessage : InventoryContentMessage
{

public const uint Id = 6162;
public override uint MessageId
{
    get { return Id; }
}

public Types.Preset[] presets;
        

public InventoryContentAndPresetMessage()
{
}

public InventoryContentAndPresetMessage(Types.ObjectItem[] objects, uint kamas, Types.Preset[] presets)
         : base(objects, kamas)
        {
            this.presets = presets;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)presets.Length);
            foreach (var entry in presets)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            presets = new Types.Preset[limit];
            for (int i = 0; i < limit; i++)
            {
                 presets[i] = new Types.Preset();
                 presets[i].Deserialize(reader);
            }
            

}


}


}