


















// Generated on 06/26/2015 11:41:43
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class DecraftResultMessage : NetworkMessage
{

public const uint Id = 6569;
public override uint MessageId
{
    get { return Id; }
}

public Types.DecraftedItemStackInfo[] results;
        

public DecraftResultMessage()
{
}

public DecraftResultMessage(Types.DecraftedItemStackInfo[] results)
        {
            this.results = results;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)results.Length);
            foreach (var entry in results)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            results = new Types.DecraftedItemStackInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 results[i] = new Types.DecraftedItemStackInfo();
                 results[i].Deserialize(reader);
            }
            

}


}


}