


















// Generated on 06/26/2015 11:42:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameFightFighterInformations : GameContextActorInformations
{

public const short Id = 143;
public override short TypeId
{
    get { return Id; }
}

public sbyte teamId;
        public sbyte wave;
        public bool alive;
        public Types.GameFightMinimalStats stats;
        public ushort[] previousPositions;
        

public GameFightFighterInformations()
{
}

public GameFightFighterInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, ushort[] previousPositions)
         : base(contextualId, look, disposition)
        {
            this.teamId = teamId;
            this.wave = wave;
            this.alive = alive;
            this.stats = stats;
            this.previousPositions = previousPositions;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(teamId);
            writer.WriteSByte(wave);
            writer.WriteBoolean(alive);
            writer.WriteShort(stats.TypeId);
            stats.Serialize(writer);
            writer.WriteUShort((ushort)previousPositions.Length);
            foreach (var entry in previousPositions)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            teamId = reader.ReadSByte();
            if (teamId < 0)
                throw new Exception("Forbidden value on teamId = " + teamId + ", it doesn't respect the following condition : teamId < 0");
            wave = reader.ReadSByte();
            if (wave < 0)
                throw new Exception("Forbidden value on wave = " + wave + ", it doesn't respect the following condition : wave < 0");
            alive = reader.ReadBoolean();
            stats = Types.ProtocolTypeManager.GetInstance<Types.GameFightMinimalStats>(reader.ReadShort());
            stats.Deserialize(reader);
            var limit = reader.ReadUShort();
            previousPositions = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 previousPositions[i] = reader.ReadVaruhshort();
            }
            

}


}


}