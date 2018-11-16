


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PaddockToSellListRequestMessage : NetworkMessage
{

public const uint Id = 6141;
public override uint MessageId
{
    get { return Id; }
}

public ushort pageIndex;
        

public PaddockToSellListRequestMessage()
{
}

public PaddockToSellListRequestMessage(ushort pageIndex)
        {
            this.pageIndex = pageIndex;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(pageIndex);
            

}

public override void Deserialize(ICustomDataReader reader)
{

pageIndex = reader.ReadVaruhshort();
            if (pageIndex < 0)
                throw new Exception("Forbidden value on pageIndex = " + pageIndex + ", it doesn't respect the following condition : pageIndex < 0");
            

}


}


}