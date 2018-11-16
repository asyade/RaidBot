


















// Generated on 06/26/2015 11:41:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharacterCreationRequestMessage : NetworkMessage
{

public const uint Id = 160;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public sbyte breed;
        public bool sex;
        public int[] colors;
        public ushort cosmeticId;
        

public CharacterCreationRequestMessage()
{
}

public CharacterCreationRequestMessage(string name, sbyte breed, bool sex, int[] colors, ushort cosmeticId)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.colors = colors;
            this.cosmeticId = cosmeticId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteUShort((ushort)colors.Length);
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteVaruhshort(cosmeticId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

name = reader.ReadUTF();
            breed = reader.ReadSByte();
            if (breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Eliotrope)
                throw new Exception("Forbidden value on breed = " + breed + ", it doesn't respect the following condition : breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Eliotrope");
            sex = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            colors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 colors[i] = reader.ReadInt();
            }
            cosmeticId = reader.ReadVaruhshort();
            if (cosmeticId < 0)
                throw new Exception("Forbidden value on cosmeticId = " + cosmeticId + ", it doesn't respect the following condition : cosmeticId < 0");
            

}


}


}