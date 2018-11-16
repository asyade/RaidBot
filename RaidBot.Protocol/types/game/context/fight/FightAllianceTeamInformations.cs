


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightAllianceTeamInformations : FightTeamInformations
{

public const short Id = 439;
public override short TypeId
{
    get { return Id; }
}

public sbyte relation;
        

public FightAllianceTeamInformations()
{
}

public FightAllianceTeamInformations(sbyte teamId, int leaderId, sbyte teamSide, sbyte teamTypeId, sbyte nbWaves, Types.FightTeamMemberInformations[] teamMembers, sbyte relation)
         : base(teamId, leaderId, teamSide, teamTypeId, nbWaves, teamMembers)
        {
            this.relation = relation;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(relation);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            relation = reader.ReadSByte();
            if (relation < 0)
                throw new Exception("Forbidden value on relation = " + relation + ", it doesn't respect the following condition : relation < 0");
            

}


}


}