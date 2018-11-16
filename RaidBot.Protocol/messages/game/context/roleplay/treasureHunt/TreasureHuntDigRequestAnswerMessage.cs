


















// Generated on 06/26/2015 11:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TreasureHuntDigRequestAnswerMessage : NetworkMessage
{

public const uint Id = 6484;
public override uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public sbyte result;
        

public TreasureHuntDigRequestAnswerMessage()
{
}

public TreasureHuntDigRequestAnswerMessage(sbyte questType, sbyte result)
        {
            this.questType = questType;
            this.result = result;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(questType);
            writer.WriteSByte(result);
            

}

public override void Deserialize(ICustomDataReader reader)
{

questType = reader.ReadSByte();
            if (questType < 0)
                throw new Exception("Forbidden value on questType = " + questType + ", it doesn't respect the following condition : questType < 0");
            result = reader.ReadSByte();
            if (result < 0)
                throw new Exception("Forbidden value on result = " + result + ", it doesn't respect the following condition : result < 0");
            

}


}


}