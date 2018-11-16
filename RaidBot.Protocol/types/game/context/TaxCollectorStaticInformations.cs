


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class TaxCollectorStaticInformations
{

public const short Id = 147;
public virtual short TypeId
{
    get { return Id; }
}

public ushort firstNameId;
        public ushort lastNameId;
        public Types.GuildInformations guildIdentity;
        

public TaxCollectorStaticInformations()
{
}

public TaxCollectorStaticInformations(ushort firstNameId, ushort lastNameId, Types.GuildInformations guildIdentity)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.guildIdentity = guildIdentity;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(firstNameId);
            writer.WriteVaruhshort(lastNameId);
            guildIdentity.Serialize(writer);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

firstNameId = reader.ReadVaruhshort();
            if (firstNameId < 0)
                throw new Exception("Forbidden value on firstNameId = " + firstNameId + ", it doesn't respect the following condition : firstNameId < 0");
            lastNameId = reader.ReadVaruhshort();
            if (lastNameId < 0)
                throw new Exception("Forbidden value on lastNameId = " + lastNameId + ", it doesn't respect the following condition : lastNameId < 0");
            guildIdentity = new Types.GuildInformations();
            guildIdentity.Deserialize(reader);
            

}


}


}