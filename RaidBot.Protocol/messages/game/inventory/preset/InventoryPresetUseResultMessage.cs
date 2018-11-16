


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InventoryPresetUseResultMessage : NetworkMessage
{

public const uint Id = 6163;
public override uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public sbyte code;
        public byte[] unlinkedPosition;
        

public InventoryPresetUseResultMessage()
{
}

public InventoryPresetUseResultMessage(sbyte presetId, sbyte code, byte[] unlinkedPosition)
        {
            this.presetId = presetId;
            this.code = code;
            this.unlinkedPosition = unlinkedPosition;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(presetId);
            writer.WriteSByte(code);
            writer.WriteUShort((ushort)unlinkedPosition.Length);
            foreach (var entry in unlinkedPosition)
            {
                 writer.WriteByte(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            code = reader.ReadSByte();
            if (code < 0)
                throw new Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
            var limit = reader.ReadUShort();
            unlinkedPosition = new byte[limit];
            for (int i = 0; i < limit; i++)
            {
                 unlinkedPosition[i] = reader.ReadByte();
            }
            

}


}


}