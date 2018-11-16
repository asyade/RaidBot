


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class EntityLook
{

public const short Id = 55;
public virtual short TypeId
{
    get { return Id; }
}

public ushort bonesId;
        public ushort[] skins;
        public int[] indexedColors;
        public short[] scales;
        public Types.SubEntity[] subentities;
        

public EntityLook()
{
}

public EntityLook(ushort bonesId, ushort[] skins, int[] indexedColors, short[] scales, Types.SubEntity[] subentities)
        {
            this.bonesId = bonesId;
            this.skins = skins;
            this.indexedColors = indexedColors;
            this.scales = scales;
            this.subentities = subentities;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(bonesId);
            writer.WriteUShort((ushort)skins.Length);
            foreach (var entry in skins)
            {
                 writer.WriteVaruhshort(entry);
            }
            writer.WriteUShort((ushort)indexedColors.Length);
            foreach (var entry in indexedColors)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteUShort((ushort)scales.Length);
            foreach (var entry in scales)
            {
                 writer.WriteVarshort(entry);
            }
            writer.WriteUShort((ushort)subentities.Length);
            foreach (var entry in subentities)
            {
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

bonesId = reader.ReadVaruhshort();
            if (bonesId < 0)
                throw new Exception("Forbidden value on bonesId = " + bonesId + ", it doesn't respect the following condition : bonesId < 0");
            var limit = reader.ReadUShort();
            skins = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 skins[i] = reader.ReadVaruhshort();
            }
            limit = reader.ReadUShort();
            indexedColors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 indexedColors[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            scales = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 scales[i] = reader.ReadVarshort();
            }
            limit = reader.ReadUShort();
            subentities = new Types.SubEntity[limit];
            for (int i = 0; i < limit; i++)
            {
                 subentities[i] = new Types.SubEntity();
                 subentities[i].Deserialize(reader);
            }
            

}


}


}