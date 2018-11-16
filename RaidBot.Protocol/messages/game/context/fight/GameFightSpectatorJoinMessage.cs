


















// Generated on 06/26/2015 11:41:17
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightSpectatorJoinMessage : GameFightJoinMessage
{

public const uint Id = 6504;
public override uint MessageId
{
    get { return Id; }
}

public Types.NamedPartyTeam[] namedPartyTeams;
        

public GameFightSpectatorJoinMessage()
{
}

public GameFightSpectatorJoinMessage(bool canBeCancelled, bool canSayReady, bool isFightStarted, short timeMaxBeforeFightStart, sbyte fightType, Types.NamedPartyTeam[] namedPartyTeams)
         : base(canBeCancelled, canSayReady, isFightStarted, timeMaxBeforeFightStart, fightType)
        {
            this.namedPartyTeams = namedPartyTeams;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)namedPartyTeams.Length);
            foreach (var entry in namedPartyTeams)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            namedPartyTeams = new Types.NamedPartyTeam[limit];
            for (int i = 0; i < limit; i++)
            {
                 namedPartyTeams[i] = new Types.NamedPartyTeam();
                 namedPartyTeams[i].Deserialize(reader);
            }
            

}


}


}