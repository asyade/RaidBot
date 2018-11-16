


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AbstractCharacterToRefurbishInformation : AbstractCharacterInformation
{

public const short Id = 475;
public override short TypeId
{
    get { return Id; }
}

public int[] colors;
        public uint cosmeticId;
        

public AbstractCharacterToRefurbishInformation()
{
}

public AbstractCharacterToRefurbishInformation(uint id, int[] colors, uint cosmeticId)
         : base(id)
        {
            this.colors = colors;
            this.cosmeticId = cosmeticId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)colors.Length);
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteVaruhint(cosmeticId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            colors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 colors[i] = reader.ReadInt();
            }
            cosmeticId = reader.ReadVaruhint();
            if (cosmeticId < 0)
                throw new Exception("Forbidden value on cosmeticId = " + cosmeticId + ", it doesn't respect the following condition : cosmeticId < 0");
            

}


}


}