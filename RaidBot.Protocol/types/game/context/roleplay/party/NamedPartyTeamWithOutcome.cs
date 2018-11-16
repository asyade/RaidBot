


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class NamedPartyTeamWithOutcome
{

public const short Id = 470;
public virtual short TypeId
{
    get { return Id; }
}

public Types.NamedPartyTeam team;
        public ushort outcome;
        

public NamedPartyTeamWithOutcome()
{
}

public NamedPartyTeamWithOutcome(Types.NamedPartyTeam team, ushort outcome)
        {
            this.team = team;
            this.outcome = outcome;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

team.Serialize(writer);
            writer.WriteVaruhshort(outcome);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

team = new Types.NamedPartyTeam();
            team.Deserialize(reader);
            outcome = reader.ReadVaruhshort();
            if (outcome < 0)
                throw new Exception("Forbidden value on outcome = " + outcome + ", it doesn't respect the following condition : outcome < 0");
            

}


}


}