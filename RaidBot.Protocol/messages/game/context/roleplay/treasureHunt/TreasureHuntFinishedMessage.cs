


















// Generated on 06/26/2015 11:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TreasureHuntFinishedMessage : NetworkMessage
{

public const uint Id = 6483;
public override uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        

public TreasureHuntFinishedMessage()
{
}

public TreasureHuntFinishedMessage(sbyte questType)
        {
            this.questType = questType;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(questType);
            

}

public override void Deserialize(ICustomDataReader reader)
{

questType = reader.ReadSByte();
            if (questType < 0)
                throw new Exception("Forbidden value on questType = " + questType + ", it doesn't respect the following condition : questType < 0");
            

}


}


}