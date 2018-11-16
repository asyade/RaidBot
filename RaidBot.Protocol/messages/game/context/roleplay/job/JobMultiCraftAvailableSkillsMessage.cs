


















// Generated on 06/26/2015 11:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class JobMultiCraftAvailableSkillsMessage : JobAllowMultiCraftRequestMessage
{

public const uint Id = 5747;
public override uint MessageId
{
    get { return Id; }
}

public uint playerId;
        public ushort[] skills;
        

public JobMultiCraftAvailableSkillsMessage()
{
}

public JobMultiCraftAvailableSkillsMessage(bool enabled, uint playerId, ushort[] skills)
         : base(enabled)
        {
            this.playerId = playerId;
            this.skills = skills;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(playerId);
            writer.WriteUShort((ushort)skills.Length);
            foreach (var entry in skills)
            {
                 writer.WriteVaruhshort(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            var limit = reader.ReadUShort();
            skills = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 skills[i] = reader.ReadVaruhshort();
            }
            

}


}


}