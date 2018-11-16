


















// Generated on 06/26/2015 11:41:24
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class HouseKickIndoorMerchantRequestMessage : NetworkMessage
{

public const uint Id = 5661;
public override uint MessageId
{
    get { return Id; }
}

public ushort cellId;
        

public HouseKickIndoorMerchantRequestMessage()
{
}

public HouseKickIndoorMerchantRequestMessage(ushort cellId)
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