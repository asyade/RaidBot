


















// Generated on 06/26/2015 11:42:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GuildInAllianceVersatileInformations : GuildVersatileInformations
{

public const short Id = 437;
public override short TypeId
{
    get { return Id; }
}

public uint allianceId;
        

public GuildInAllianceVersatileInformations()
{
}

public GuildInAllianceVersatileInformations(uint guildId, uint leaderId, byte guildLevel, byte nbMembers, uint allianceId)
         : base(guildId, leaderId, guildLevel, nbMembers)
        {
            this.allianceId = allianceId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(allianceId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            allianceId = reader.ReadVaruhint();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            

}


}


}