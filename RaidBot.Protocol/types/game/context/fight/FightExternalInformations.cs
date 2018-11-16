


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightExternalInformations
{

public const short Id = 117;
public virtual short TypeId
{
    get { return Id; }
}

public int fightId;
        public sbyte fightType;
        public int fightStart;
        public bool fightSpectatorLocked;
        public Types.FightTeamLightInformations[] fightTeams;
        public Types.FightOptionsInformations[] fightTeamsOptions;
        

public FightExternalInformations()
{
}

public FightExternalInformations(int fightId, sbyte fightType, int fightStart, bool fightSpectatorLocked, Types.FightTeamLightInformations[] fightTeams, Types.FightOptionsInformations[] fightTeamsOptions)
        {
            this.fightId = fightId;
            this.fightType = fightType;
            this.fightStart = fightStart;
            this.fightSpectatorLocked = fightSpectatorLocked;
            this.fightTeams = fightTeams;
            this.fightTeamsOptions = fightTeamsOptions;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteSByte(fightType);
            writer.WriteInt(fightStart);
            writer.WriteBoolean(fightSpectatorLocked);
            writer.WriteUShort((ushort)fightTeams.Length);
            foreach (var entry in fightTeams)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)fightTeamsOptions.Length);
            foreach (var entry in fightTeamsOptions)
            {
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

fightId = reader.ReadInt();
            fightType = reader.ReadSByte();
            if (fightType < 0)
                throw new Exception("Forbidden value on fightType = " + fightType + ", it doesn't respect the following condition : fightType < 0");
            fightStart = reader.ReadInt();
            if (fightStart < 0)
                throw new Exception("Forbidden value on fightStart = " + fightStart + ", it doesn't respect the following condition : fightStart < 0");
            fightSpectatorLocked = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            fightTeams = new Types.FightTeamLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightTeams[i] = new Types.FightTeamLightInformations();
                 fightTeams[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            fightTeamsOptions = new Types.FightOptionsInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightTeamsOptions[i] = new Types.FightOptionsInformations();
                 fightTeamsOptions[i].Deserialize(reader);
            }
            

}


}


}