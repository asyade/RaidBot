


















// Generated on 06/26/2015 11:41:15
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class DungeonKeyRingUpdateMessage : NetworkMessage
{

public const uint Id = 6296;
public override uint MessageId
{
    get { return Id; }
}

public ushort dungeonId;
        public bool available;
        

public DungeonKeyRingUpdateMessage()
{
}

public DungeonKeyRingUpdateMessage(ushort dungeonId, bool available)
        {
            this.dungeonId = dungeonId;
            this.available = available;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(dungeonId);
            writer.WriteBoolean(available);
            

}

public override void Deserialize(ICustomDataReader reader)
{

dungeonId = reader.ReadVaruhshort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            available = reader.ReadBoolean();
            

}


}


}