


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class RemodelingInformation
{

public const short Id = 480;
public virtual short TypeId
{
    get { return Id; }
}

public string name;
        public sbyte breed;
        public bool sex;
        public ushort cosmeticId;
        public int[] colors;
        

public RemodelingInformation()
{
}

public RemodelingInformation(string name, sbyte breed, bool sex, ushort cosmeticId, int[] colors)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.cosmeticId = cosmeticId;
            this.colors = colors;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteVaruhshort(cosmeticId);
            writer.WriteUShort((ushort)colors.Length);
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

name = reader.ReadUTF();
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            cosmeticId = reader.ReadVaruhshort();
            if (cosmeticId < 0)
                throw new Exception("Forbidden value on cosmeticId = " + cosmeticId + ", it doesn't respect the following condition : cosmeticId < 0");
            var limit = reader.ReadUShort();
            colors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 colors[i] = reader.ReadInt();
            }
            

}


}


}