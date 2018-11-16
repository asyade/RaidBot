


















// Generated on 06/26/2015 11:41:15
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightEndMessage : NetworkMessage
{

public const uint Id = 720;
public override uint MessageId
{
    get { return Id; }
}

public int duration;
        public short ageBonus;
        public short lootShareLimitMalus;
        public Types.FightResultListEntry[] results;
        public Types.NamedPartyTeamWithOutcome[] namedPartyTeamsOutcomes;
        

public GameFightEndMessage()
{
}

public GameFightEndMessage(int duration, short ageBonus, short lootShareLimitMalus, Types.FightResultListEntry[] results, Types.NamedPartyTeamWithOutcome[] namedPartyTeamsOutcomes)
        {
            this.duration = duration;
            this.ageBonus = ageBonus;
            this.lootShareLimitMalus = lootShareLimitMalus;
            this.results = results;
            this.namedPartyTeamsOutcomes = namedPartyTeamsOutcomes;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(duration);
            writer.WriteShort(ageBonus);
            writer.WriteShort(lootShareLimitMalus);
            writer.WriteUShort((ushort)results.Length);
            foreach (var entry in results)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)namedPartyTeamsOutcomes.Length);
            foreach (var entry in namedPartyTeamsOutcomes)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

duration = reader.ReadInt();
            if (duration < 0)
                throw new Exception("Forbidden value on duration = " + duration + ", it doesn't respect the following condition : duration < 0");
            ageBonus = reader.ReadShort();
            lootShareLimitMalus = reader.ReadShort();
            var limit = reader.ReadUShort();
            results = new Types.FightResultListEntry[limit];
            for (int i = 0; i < limit; i++)
            {
                 results[i] = Types.ProtocolTypeManager.GetInstance<Types.FightResultListEntry>(reader.ReadShort());
                 results[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            namedPartyTeamsOutcomes = new Types.NamedPartyTeamWithOutcome[limit];
            for (int i = 0; i < limit; i++)
            {
                 namedPartyTeamsOutcomes[i] = new Types.NamedPartyTeamWithOutcome();
                 namedPartyTeamsOutcomes[i].Deserialize(reader);
            }
            

}


}


}