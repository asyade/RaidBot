


















// Generated on 06/26/2015 11:41:28
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class DungeonPartyFinderRoomContentUpdateMessage : NetworkMessage
{

public const uint Id = 6250;
public override uint MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        public Types.DungeonPartyFinderPlayer[] addedPlayers;
        public uint[] removedPlayersIds;
        

public DungeonPartyFinderRoomContentUpdateMessage()
{
}

public DungeonPartyFinderRoomContentUpdateMessage(ushort dungeonId, Types.DungeonPartyFinderPlayer[] addedPlayers, uint[] removedPlayersIds)
        {
            this.dungeonId = dungeonId;
            this.addedPlayers = addedPlayers;
            this.removedPlayersIds = removedPlayersIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(dungeonId);
            writer.WriteUShort((ushort)addedPlayers.Length);
            foreach (var entry in addedPlayers)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)removedPlayersIds.Length);
            foreach (var entry in removedPlayersIds)
            {
                 writer.WriteVaruhint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

dungeonId = reader.ReadVaruhshort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            var limit = reader.ReadUShort();
            addedPlayers = new Types.DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 addedPlayers[i] = new Types.DungeonPartyFinderPlayer();
                 addedPlayers[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            removedPlayersIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 removedPlayersIds[i] = reader.ReadVaruhint();
            }
            

}


}


}