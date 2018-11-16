


















// Generated on 06/26/2015 11:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TreasureHuntFlagRemoveRequestMessage : NetworkMessage
{

public const uint Id = 6510;
public override uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public sbyte index;
        

public TreasureHuntFlagRemoveRequestMessage()
{
}

public TreasureHuntFlagRemoveRequestMessage(sbyte questType, sbyte index)
        {
            this.questType = questType;
            this.index = index;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(questType);
            writer.WriteSByte(index);
            

}

public override void Deserialize(ICustomDataReader reader)
{

questType = reader.ReadSByte();
            if (questType < 0)
                throw new Exception("Forbidden value on questType = " + questType + ", it doesn't respect the following condition : questType < 0");
            index = reader.ReadSByte();
            if (index < 0)
                throw new Exception("Forbidden value on index = " + index + ", it doesn't respect the following condition : index < 0");
            

}


}


}