


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class CharacterToRecolorInformation : AbstractCharacterToRefurbishInformation
{

public const short Id = 212;
public override short TypeId
{
    get { return Id; }
}



public CharacterToRecolorInformation()
{
}

public CharacterToRecolorInformation(uint id, int[] colors, uint cosmeticId)
         : base(id, colors, cosmeticId)
        {
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            

}


}


}