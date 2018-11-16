


















// Generated on 06/26/2015 11:42:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameRolePlayNpcInformations : GameRolePlayActorInformations
{

public const short Id = 156;
public override short TypeId
{
    get { return Id; }
}

public ushort npcId;
        public bool sex;
        public ushort specialArtworkId;
        

public GameRolePlayNpcInformations()
{
}

public GameRolePlayNpcInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, ushort npcId, bool sex, ushort specialArtworkId)
         : base(contextualId, look, disposition)
        {
            this.npcId = npcId;
            this.sex = sex;
            this.specialArtworkId = specialArtworkId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(npcId);
            writer.WriteBoolean(sex);
            writer.WriteVaruhshort(specialArtworkId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            npcId = reader.ReadVaruhshort();
            if (npcId < 0)
                throw new Exception("Forbidden value on npcId = " + npcId + ", it doesn't respect the following condition : npcId < 0");
            sex = reader.ReadBoolean();
            specialArtworkId = reader.ReadVaruhshort();
            if (specialArtworkId < 0)
                throw new Exception("Forbidden value on specialArtworkId = " + specialArtworkId + ", it doesn't respect the following condition : specialArtworkId < 0");
            

}


}


}