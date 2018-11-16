


















// Generated on 06/26/2015 11:42:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameRolePlayGroupMonsterWaveInformations : GameRolePlayGroupMonsterInformations
{

public const short Id = 464;
public override short TypeId
{
    get { return Id; }
}

public sbyte nbWaves;
        public Types.GroupMonsterStaticInformations[] alternatives;
        

public GameRolePlayGroupMonsterWaveInformations()
{
}

public GameRolePlayGroupMonsterWaveInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, bool keyRingBonus, bool hasHardcoreDrop, bool hasAVARewardToken, Types.GroupMonsterStaticInformations staticInfos, short ageBonus, sbyte lootShare, sbyte alignmentSide, sbyte nbWaves, Types.GroupMonsterStaticInformations[] alternatives)
         : base(contextualId, look, disposition, keyRingBonus, hasHardcoreDrop, hasAVARewardToken, staticInfos, ageBonus, lootShare, alignmentSide)
        {
            this.nbWaves = nbWaves;
            this.alternatives = alternatives;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(nbWaves);
            writer.WriteUShort((ushort)alternatives.Length);
            foreach (var entry in alternatives)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            nbWaves = reader.ReadSByte();
            if (nbWaves < 0)
                throw new Exception("Forbidden value on nbWaves = " + nbWaves + ", it doesn't respect the following condition : nbWaves < 0");
            var limit = reader.ReadUShort();
            alternatives = new Types.GroupMonsterStaticInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alternatives[i] = Types.ProtocolTypeManager.GetInstance<Types.GroupMonsterStaticInformations>(reader.ReadShort());
                 alternatives[i].Deserialize(reader);
            }
            

}


}


}