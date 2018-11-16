


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameMapMovementRequestMessage : NetworkMessage
{

public const uint Id = 950;
public override uint MessageId
{
    get { return Id; }
}

public short[] keyMovements;
        public int mapId;
        

public GameMapMovementRequestMessage()
{
}

public GameMapMovementRequestMessage(short[] keyMovements, int mapId)
        {
            this.keyMovements = keyMovements;
            this.mapId = mapId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)keyMovements.Length);
            foreach (var entry in keyMovements)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteInt(mapId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            keyMovements = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 keyMovements[i] = reader.ReadShort();
            }
            mapId = reader.ReadInt();
            if (mapId < 0)
                throw new Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            

}


}


}