


















// Generated on 06/26/2015 11:42:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameFightMonsterInformations : GameFightAIInformations
{

public const short Id = 29;
public override short TypeId
{
    get { return Id; }
}

public ushort creatureGenericId;
        public sbyte creatureGrade;
        

public GameFightMonsterInformations()
{
}

public GameFightMonsterInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, ushort[] previousPositions, ushort creatureGenericId, sbyte creatureGrade)
         : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions)
        {
            this.creatureGenericId = creatureGenericId;
            this.creatureGrade = creatureGrade;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(creatureGenericId);
            writer.WriteSByte(creatureGrade);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            creatureGenericId = reader.ReadVaruhshort();
            if (creatureGenericId < 0)
                throw new Exception("Forbidden value on creatureGenericId = " + creatureGenericId + ", it doesn't respect the following condition : creatureGenericId < 0");
            creatureGrade = reader.ReadSByte();
            if (creatureGrade < 0)
                throw new Exception("Forbidden value on creatureGrade = " + creatureGrade + ", it doesn't respect the following condition : creatureGrade < 0");
            

}


}


}