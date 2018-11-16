


















// Generated on 06/26/2015 11:41:21
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TeleportOnSameMapMessage : NetworkMessage
{

public const uint Id = 6048;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public ushort cellId;
        

public TeleportOnSameMapMessage()
{
}

public TeleportOnSameMapMessage(int targetId, ushort cellId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(targetId);
            writer.WriteVaruhshort(cellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

targetId = reader.ReadInt();
            cellId = reader.ReadVaruhshort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}