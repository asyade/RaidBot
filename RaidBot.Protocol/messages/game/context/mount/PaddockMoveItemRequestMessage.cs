


















// Generated on 06/26/2015 11:41:20
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PaddockMoveItemRequestMessage : NetworkMessage
{

public const uint Id = 6052;
public override uint MessageId
{
    get { return Id; }
}

public ushort oldCellId;
        public ushort newCellId;
        

public PaddockMoveItemRequestMessage()
{
}

public PaddockMoveItemRequestMessage(ushort oldCellId, ushort newCellId)
        {
            this.oldCellId = oldCellId;
            this.newCellId = newCellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(oldCellId);
            writer.WriteVaruhshort(newCellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

oldCellId = reader.ReadVaruhshort();
            if (oldCellId < 0 || oldCellId > 559)
                throw new Exception("Forbidden value on oldCellId = " + oldCellId + ", it doesn't respect the following condition : oldCellId < 0 || oldCellId > 559");
            newCellId = reader.ReadVaruhshort();
            if (newCellId < 0 || newCellId > 559)
                throw new Exception("Forbidden value on newCellId = " + newCellId + ", it doesn't respect the following condition : newCellId < 0 || newCellId > 559");
            

}


}


}