


















// Generated on 06/26/2015 11:41:21
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MapFightCountMessage : NetworkMessage
{

public const uint Id = 210;
public override uint MessageId
{
    get { return Id; }
}

public ushort fightCount;
        

public MapFightCountMessage()
{
}

public MapFightCountMessage(ushort fightCount)
        {
            this.fightCount = fightCount;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(fightCount);
            

}

public override void Deserialize(ICustomDataReader reader)
{

fightCount = reader.ReadVaruhshort();
            if (fightCount < 0)
                throw new Exception("Forbidden value on fightCount = " + fightCount + ", it doesn't respect the following condition : fightCount < 0");
            

}


}


}