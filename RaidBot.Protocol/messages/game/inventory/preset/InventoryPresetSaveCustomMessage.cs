


















// Generated on 06/26/2015 11:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InventoryPresetSaveCustomMessage : NetworkMessage
{

public const uint Id = 6329;
public override uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public sbyte symbolId;
        public byte[] itemsPositions;
        public uint[] itemsUids;
        

public InventoryPresetSaveCustomMessage()
{
}

public InventoryPresetSaveCustomMessage(sbyte presetId, sbyte symbolId, byte[] itemsPositions, uint[] itemsUids)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
            this.itemsPositions = itemsPositions;
            this.itemsUids = itemsUids;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(presetId);
            writer.WriteSByte(symbolId);
            writer.WriteUShort((ushort)itemsPositions.Length);
            foreach (var entry in itemsPositions)
            {
                 writer.WriteByte(entry);
            }
            writer.WriteUShort((ushort)itemsUids.Length);
            foreach (var entry in itemsUids)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            symbolId = reader.ReadSByte();
            if (symbolId < 0)
                throw new Exception("Forbidden value on symbolId = " + symbolId + ", it doesn't respect the following condition : symbolId < 0");
            var limit = reader.ReadUShort();
            itemsPositions = new byte[limit];
            for (int i = 0; i < limit; i++)
            {
                 itemsPositions[i] = reader.ReadByte();
            }
            limit = reader.ReadUShort();
            itemsUids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 itemsUids[i] = reader.ReadVaruhint();
            }
            

}


}


}