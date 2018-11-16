


















// Generated on 06/26/2015 11:42:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameRolePlayNpcWithQuestInformations : GameRolePlayNpcInformations
{

public const short Id = 383;
public override short TypeId
{
    get { return Id; }
}

public Types.GameRolePlayNpcQuestFlag questFlag;
        

public GameRolePlayNpcWithQuestInformations()
{
}

public GameRolePlayNpcWithQuestInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, ushort npcId, bool sex, ushort specialArtworkId, Types.GameRolePlayNpcQuestFlag questFlag)
         : base(contextualId, look, disposition, npcId, sex, specialArtworkId)
        {
            this.questFlag = questFlag;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            questFlag.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            questFlag = new Types.GameRolePlayNpcQuestFlag();
            questFlag.Deserialize(reader);
            

}


}


}