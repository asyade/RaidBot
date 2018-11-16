


















// Generated on 06/26/2015 11:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeMountsStableRemoveMessage : NetworkMessage
{

public const uint Id = 6556;
public override uint MessageId
{
    get { return Id; }
}

public int[] mountsId;
        

public ExchangeMountsStableRemoveMessage()
{
}

public ExchangeMountsStableRemoveMessage(int[] mountsId)
        {
            this.mountsId = mountsId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)mountsId.Length);
            foreach (var entry in mountsId)
            {
                 writer.WriteVarint(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            mountsId = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 mountsId[i] = reader.ReadVarint();
            }
            

}


}


}