


















// Generated on 06/26/2015 11:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildFightPlayersEnemiesListMessage : NetworkMessage
{

public const uint Id = 5928;
public override uint MessageId
{
    get { return Id; }
}

public int fightId;
        public Types.CharacterMinimalPlusLookInformations[] playerInfo;
        

public GuildFightPlayersEnemiesListMessage()
{
}

public GuildFightPlayersEnemiesListMessage(int fightId, Types.CharacterMinimalPlusLookInformations[] playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteUShort((ushort)playerInfo.Length);
            foreach (var entry in playerInfo)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

fightId = reader.ReadInt();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            var limit = reader.ReadUShort();
            playerInfo = new Types.CharacterMinimalPlusLookInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 playerInfo[i] = new Types.CharacterMinimalPlusLookInformations();
                 playerInfo[i].Deserialize(reader);
            }
            

}


}


}