


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InventoryPresetUseMessage : NetworkMessage
{

public const uint Id = 6167;
public override uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        

public InventoryPresetUseMessage()
{
}

public InventoryPresetUseMessage(sbyte presetId)
        {
            this.presetId = presetId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(presetId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            

}


}


}