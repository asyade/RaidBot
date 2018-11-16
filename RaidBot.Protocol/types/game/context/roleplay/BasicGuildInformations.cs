


















// Generated on 06/26/2015 11:42:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class BasicGuildInformations : AbstractSocialGroupInfos
{

public const short Id = 365;
public override short TypeId
{
    get { return Id; }
}

public uint guildId;
        public string guildName;
        

public BasicGuildInformations()
{
}

public BasicGuildInformations(uint guildId, string guildName)
        {
            this.guildId = guildId;
            this.guildName = guildName;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(guildId);
            writer.WriteUTF(guildName);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            guildId = reader.ReadVaruhint();
            if (guildId < 0)
                throw new Exception("Forbidden value on guildId = " + guildId + ", it doesn't respect the following condition : guildId < 0");
            guildName = reader.ReadUTF();
            

}


}


}