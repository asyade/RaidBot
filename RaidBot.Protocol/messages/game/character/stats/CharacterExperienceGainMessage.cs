


















// Generated on 06/26/2015 11:41:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharacterExperienceGainMessage : NetworkMessage
{

public const uint Id = 6321;
public override uint MessageId
{
    get { return Id; }
}

public ulong experienceCharacter;
        public ulong experienceMount;
        public ulong experienceGuild;
        public ulong experienceIncarnation;
        

public CharacterExperienceGainMessage()
{
}

public CharacterExperienceGainMessage(ulong experienceCharacter, ulong experienceMount, ulong experienceGuild, ulong experienceIncarnation)
        {
            this.experienceCharacter = experienceCharacter;
            this.experienceMount = experienceMount;
            this.experienceGuild = experienceGuild;
            this.experienceIncarnation = experienceIncarnation;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhlong(experienceCharacter);
            writer.WriteVaruhlong(experienceMount);
            writer.WriteVaruhlong(experienceGuild);
            writer.WriteVaruhlong(experienceIncarnation);
            

}

public override void Deserialize(ICustomDataReader reader)
{

experienceCharacter = reader.ReadVaruhlong();
            if (experienceCharacter < 0 || experienceCharacter > 9.007199254740992E15)
                throw new Exception("Forbidden value on experienceCharacter = " + experienceCharacter + ", it doesn't respect the following condition : experienceCharacter < 0 || experienceCharacter > 9.007199254740992E15");
            experienceMount = reader.ReadVaruhlong();
            if (experienceMount < 0 || experienceMount > 9.007199254740992E15)
                throw new Exception("Forbidden value on experienceMount = " + experienceMount + ", it doesn't respect the following condition : experienceMount < 0 || experienceMount > 9.007199254740992E15");
            experienceGuild = reader.ReadVaruhlong();
            if (experienceGuild < 0 || experienceGuild > 9.007199254740992E15)
                throw new Exception("Forbidden value on experienceGuild = " + experienceGuild + ", it doesn't respect the following condition : experienceGuild < 0 || experienceGuild > 9.007199254740992E15");
            experienceIncarnation = reader.ReadVaruhlong();
            if (experienceIncarnation < 0 || experienceIncarnation > 9.007199254740992E15)
                throw new Exception("Forbidden value on experienceIncarnation = " + experienceIncarnation + ", it doesn't respect the following condition : experienceIncarnation < 0 || experienceIncarnation > 9.007199254740992E15");
            

}


}


}