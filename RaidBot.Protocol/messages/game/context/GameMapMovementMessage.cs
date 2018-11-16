


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameMapMovementMessage : NetworkMessage
{

public const uint Id = 951;
public override uint MessageId
{
    get { return Id; }
}

public short[] keyMovements;
        public int actorId;
        

public GameMapMovementMessage()
{
}

public GameMapMovementMessage(short[] keyMovements, int actorId)
        {
            this.keyMovements = keyMovements;
            this.actorId = actorId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)keyMovements.Length);
            foreach (var entry in keyMovements)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteInt(actorId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            keyMovements = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 keyMovements[i] = reader.ReadShort();
            }
            actorId = reader.ReadInt();
            

}


}


}