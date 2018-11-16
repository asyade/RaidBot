


















// Generated on 06/26/2015 11:42:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AllianceVersatileInformations
{

public const short Id = 432;
public virtual short TypeId
{
    get { return Id; }
}

public uint allianceId;
        public ushort nbGuilds;
        public ushort nbMembers;
        public ushort nbSubarea;
        

public AllianceVersatileInformations()
{
}

public AllianceVersatileInformations(uint allianceId, ushort nbGuilds, ushort nbMembers, ushort nbSubarea)
        {
            this.allianceId = allianceId;
            this.nbGuilds = nbGuilds;
            this.nbMembers = nbMembers;
            this.nbSubarea = nbSubarea;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(allianceId);
            writer.WriteVaruhshort(nbGuilds);
            writer.WriteVaruhshort(nbMembers);
            writer.WriteVaruhshort(nbSubarea);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

allianceId = reader.ReadVaruhint();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            nbGuilds = reader.ReadVaruhshort();
            if (nbGuilds < 0)
                throw new Exception("Forbidden value on nbGuilds = " + nbGuilds + ", it doesn't respect the following condition : nbGuilds < 0");
            nbMembers = reader.ReadVaruhshort();
            if (nbMembers < 0)
                throw new Exception("Forbidden value on nbMembers = " + nbMembers + ", it doesn't respect the following condition : nbMembers < 0");
            nbSubarea = reader.ReadVaruhshort();
            if (nbSubarea < 0)
                throw new Exception("Forbidden value on nbSubarea = " + nbSubarea + ", it doesn't respect the following condition : nbSubarea < 0");
            

}


}


}