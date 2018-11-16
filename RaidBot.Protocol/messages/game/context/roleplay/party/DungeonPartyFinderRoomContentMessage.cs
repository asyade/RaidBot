


















// Generated on 06/26/2015 11:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class DungeonPartyFinderRoomContentMessage : NetworkMessage
{

public const uint Id = 6247;
public override uint MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        public Types.DungeonPartyFinderPlayer[] players;
        

public DungeonPartyFinderRoomContentMessage()
{
}

public DungeonPartyFinderRoomContentMessage(ushort dungeonId, Types.DungeonPartyFinderPlayer[] players)
        {
            this.dungeonId = dungeonId;
            this.players = players;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(dungeonId);
            writer.WriteUShort((ushort)players.Length);
            foreach (var entry in players)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

dungeonId = reader.ReadVaruhshort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            var limit = reader.ReadUShort();
            players = new Types.DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 players[i] = new Types.DungeonPartyFinderPlayer();
                 players[i].Deserialize(reader);
            }
            

}


}


}