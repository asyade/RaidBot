


















// Generated on 06/26/2015 11:40:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AchievementDetailedListRequestMessage : NetworkMessage
{

public const uint Id = 6357;
public override uint MessageId
{
    get { return Id; }
}

public ushort categoryId;
        

public AchievementDetailedListRequestMessage()
{
}

public AchievementDetailedListRequestMessage(ushort categoryId)
        {
            this.categoryId = categoryId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(categoryId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

categoryId = reader.ReadVaruhshort();
            if (categoryId < 0)
                throw new Exception("Forbidden value on categoryId = " + categoryId + ", it doesn't respect the following condition : categoryId < 0");
            

}


}


}