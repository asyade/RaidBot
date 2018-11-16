


















// Generated on 06/26/2015 11:41:55
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class UpdateMapPlayersAgressableStatusMessage : NetworkMessage
{

public const uint Id = 6454;
public override uint MessageId
{
    get { return Id; }
}

public uint[] playerIds;
        public sbyte[] enable;
        

public UpdateMapPlayersAgressableStatusMessage()
{
}

public UpdateMapPlayersAgressableStatusMessage(uint[] playerIds, sbyte[] enable)
        {
            this.playerIds = playerIds;
            this.enable = enable;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)playerIds.Length);
            foreach (var entry in playerIds)
            {
                 writer.WriteVaruhint(entry);
            }
            writer.WriteUShort((ushort)enable.Length);
            foreach (var entry in enable)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            playerIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 playerIds[i] = reader.ReadVaruhint();
            }
            limit = reader.ReadUShort();
            enable = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 enable[i] = reader.ReadSByte();
            }
            

}


}


}