


















// Generated on 06/26/2015 11:42:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GuildInsiderFactSheetInformations : GuildFactSheetInformations
{

public const short Id = 423;
public override short TypeId
{
    get { return Id; }
}

public string leaderName;
        public ushort nbConnectedMembers;
        public sbyte nbTaxCollectors;
        public int lastActivity;
        public bool enabled;
        

public GuildInsiderFactSheetInformations()
{
}

public GuildInsiderFactSheetInformations(uint guildId, string guildName, Types.GuildEmblem guildEmblem, uint leaderId, byte guildLevel, ushort nbMembers, string leaderName, ushort nbConnectedMembers, sbyte nbTaxCollectors, int lastActivity, bool enabled)
         : base(guildId, guildName, guildEmblem, leaderId, guildLevel, nbMembers)
        {
            this.leaderName = leaderName;
            this.nbConnectedMembers = nbConnectedMembers;
            this.nbTaxCollectors = nbTaxCollectors;
            this.lastActivity = lastActivity;
            this.enabled = enabled;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(leaderName);
            writer.WriteVaruhshort(nbConnectedMembers);
            writer.WriteSByte(nbTaxCollectors);
            writer.WriteInt(lastActivity);
            writer.WriteBoolean(enabled);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            leaderName = reader.ReadUTF();
            nbConnectedMembers = reader.ReadVaruhshort();
            if (nbConnectedMembers < 0)
                throw new Exception("Forbidden value on nbConnectedMembers = " + nbConnectedMembers + ", it doesn't respect the following condition : nbConnectedMembers < 0");
            nbTaxCollectors = reader.ReadSByte();
            if (nbTaxCollectors < 0)
                throw new Exception("Forbidden value on nbTaxCollectors = " + nbTaxCollectors + ", it doesn't respect the following condition : nbTaxCollectors < 0");
            lastActivity = reader.ReadInt();
            if (lastActivity < 0)
                throw new Exception("Forbidden value on lastActivity = " + lastActivity + ", it doesn't respect the following condition : lastActivity < 0");
            enabled = reader.ReadBoolean();
            

}


}


}