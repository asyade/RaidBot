


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ShowCellMessage : NetworkMessage
{

public const uint Id = 5612;
public override uint MessageId
{
    get { return Id; }
}

public int sourceId;
        public ushort cellId;
        

public ShowCellMessage()
{
}

public ShowCellMessage(int sourceId, ushort cellId)
        {
            this.sourceId = sourceId;
            this.cellId = cellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(sourceId);
            writer.WriteVaruhshort(cellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

            sourceId = reader.ReadInt();
            cellId = reader.ReadVaruhshort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}