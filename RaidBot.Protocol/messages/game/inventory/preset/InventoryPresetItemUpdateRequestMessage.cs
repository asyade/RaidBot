


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InventoryPresetItemUpdateRequestMessage : NetworkMessage
{

public const uint Id = 6210;
public override uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public byte position;
        public uint objUid;
        

public InventoryPresetItemUpdateRequestMessage()
{
}

public InventoryPresetItemUpdateRequestMessage(sbyte presetId, byte position, uint objUid)
        {
            this.presetId = presetId;
            this.position = position;
            this.objUid = objUid;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(presetId);
            writer.WriteByte(position);
            writer.WriteVaruhint(objUid);
            

}

public override void Deserialize(ICustomDataReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            position = reader.ReadByte();
            if (position < 0 || position > 255)
                throw new Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 255");
            objUid = reader.ReadVaruhint();
            if (objUid < 0)
                throw new Exception("Forbidden value on objUid = " + objUid + ", it doesn't respect the following condition : objUid < 0");
            

}


}


}