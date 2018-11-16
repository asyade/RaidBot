


















// Generated on 06/26/2015 11:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildChangeMemberParametersMessage : NetworkMessage
{

public const uint Id = 5549;
public override uint MessageId
{
    get { return Id; }
}

public uint memberId;
        public ushort rank;
        public sbyte experienceGivenPercent;
        public uint rights;
        

public GuildChangeMemberParametersMessage()
{
}

public GuildChangeMemberParametersMessage(uint memberId, ushort rank, sbyte experienceGivenPercent, uint rights)
        {
            this.memberId = memberId;
            this.rank = rank;
            this.experienceGivenPercent = experienceGivenPercent;
            this.rights = rights;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(memberId);
            writer.WriteVaruhshort(rank);
            writer.WriteSByte(experienceGivenPercent);
            writer.WriteVaruhint(rights);
            

}

public override void Deserialize(ICustomDataReader reader)
{

memberId = reader.ReadVaruhint();
            if (memberId < 0)
                throw new Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0");
            rank = reader.ReadVaruhshort();
            if (rank < 0)
                throw new Exception("Forbidden value on rank = " + rank + ", it doesn't respect the following condition : rank < 0");
            experienceGivenPercent = reader.ReadSByte();
            if (experienceGivenPercent < 0 || experienceGivenPercent > 100)
                throw new Exception("Forbidden value on experienceGivenPercent = " + experienceGivenPercent + ", it doesn't respect the following condition : experienceGivenPercent < 0 || experienceGivenPercent > 100");
            rights = reader.ReadVaruhint();
            if (rights < 0)
                throw new Exception("Forbidden value on rights = " + rights + ", it doesn't respect the following condition : rights < 0");
            

}


}


}