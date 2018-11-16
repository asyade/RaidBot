


















// Generated on 06/26/2015 11:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class TreasureHuntRequestMessage : NetworkMessage
{

public const uint Id = 6488;
public override uint MessageId
{
    get { return Id; }
}

public byte questLevel;
        public sbyte questType;
        

public TreasureHuntRequestMessage()
{
}

public TreasureHuntRequestMessage(byte questLevel, sbyte questType)
        {
            this.questLevel = questLevel;
            this.questType = questType;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteByte(questLevel);
            writer.WriteSByte(questType);
            

}

public override void Deserialize(ICustomDataReader reader)
{

questLevel = reader.ReadByte();
            if (questLevel < 1 || questLevel > 200)
                throw new Exception("Forbidden value on questLevel = " + questLevel + ", it doesn't respect the following condition : questLevel < 1 || questLevel > 200");
            questType = reader.ReadSByte();
            if (questType < 0)
                throw new Exception("Forbidden value on questType = " + questType + ", it doesn't respect the following condition : questType < 0");
            

}


}


}