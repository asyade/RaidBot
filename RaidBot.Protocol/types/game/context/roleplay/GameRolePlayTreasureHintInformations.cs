


















// Generated on 06/26/2015 11:42:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameRolePlayTreasureHintInformations : GameRolePlayActorInformations
{

public const short Id = 471;
public override short TypeId
{
    get { return Id; }
}

public ushort npcId;
        

public GameRolePlayTreasureHintInformations()
{
}

public GameRolePlayTreasureHintInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, ushort npcId)
         : base(contextualId, look, disposition)
        {
            this.npcId = npcId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(npcId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            npcId = reader.ReadVaruhshort();
            if (npcId < 0)
                throw new Exception("Forbidden value on npcId = " + npcId + ", it doesn't respect the following condition : npcId < 0");
            

}


}


}