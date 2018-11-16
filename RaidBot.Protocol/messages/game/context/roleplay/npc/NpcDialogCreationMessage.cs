


















// Generated on 06/26/2015 11:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class NpcDialogCreationMessage : NetworkMessage
{

public const uint Id = 5618;
public override uint MessageId
{
    get { return Id; }
}

public int mapId;
        public int npcId;
        

public NpcDialogCreationMessage()
{
}

public NpcDialogCreationMessage(int mapId, int npcId)
        {
            this.mapId = mapId;
            this.npcId = npcId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(mapId);
            writer.WriteInt(npcId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

mapId = reader.ReadInt();
            npcId = reader.ReadInt();
            

}


}


}