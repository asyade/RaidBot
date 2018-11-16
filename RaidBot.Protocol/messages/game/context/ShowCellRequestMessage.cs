


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ShowCellRequestMessage : NetworkMessage
{

public const uint Id = 5611;
public override uint MessageId
{
    get { return Id; }
}

public ushort cellId;
        

public ShowCellRequestMessage()
{
}

public ShowCellRequestMessage(ushort cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(cellId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

cellId = reader.ReadVaruhshort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}