


















// Generated on 06/26/2015 11:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TreasureHuntDigRequestAnswerFailedMessage : TreasureHuntDigRequestAnswerMessage
{

public const uint Id = 6509;
public override uint MessageId
{
    get { return Id; }
}

public sbyte wrongFlagCount;
        

public TreasureHuntDigRequestAnswerFailedMessage()
{
}

public TreasureHuntDigRequestAnswerFailedMessage(sbyte questType, sbyte result, sbyte wrongFlagCount)
         : base(questType, result)
        {
            this.wrongFlagCount = wrongFlagCount;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(wrongFlagCount);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            wrongFlagCount = reader.ReadSByte();
            if (wrongFlagCount < 0)
                throw new Exception("Forbidden value on wrongFlagCount = " + wrongFlagCount + ", it doesn't respect the following condition : wrongFlagCount < 0");
            

}


}


}