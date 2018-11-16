


















// Generated on 06/26/2015 11:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStartedWithPodsMessage : ExchangeStartedMessage
{

public const uint Id = 6129;
public override uint MessageId
{
    get { return Id; }
}

public int firstCharacterId;
        public uint firstCharacterCurrentWeight;
        public uint firstCharacterMaxWeight;
        public int secondCharacterId;
        public uint secondCharacterCurrentWeight;
        public uint secondCharacterMaxWeight;
        

public ExchangeStartedWithPodsMessage()
{
}

public ExchangeStartedWithPodsMessage(sbyte exchangeType, int firstCharacterId, uint firstCharacterCurrentWeight, uint firstCharacterMaxWeight, int secondCharacterId, uint secondCharacterCurrentWeight, uint secondCharacterMaxWeight)
         : base(exchangeType)
        {
            this.firstCharacterId = firstCharacterId;
            this.firstCharacterCurrentWeight = firstCharacterCurrentWeight;
            this.firstCharacterMaxWeight = firstCharacterMaxWeight;
            this.secondCharacterId = secondCharacterId;
            this.secondCharacterCurrentWeight = secondCharacterCurrentWeight;
            this.secondCharacterMaxWeight = secondCharacterMaxWeight;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(firstCharacterId);
            writer.WriteVaruhint(firstCharacterCurrentWeight);
            writer.WriteVaruhint(firstCharacterMaxWeight);
            writer.WriteInt(secondCharacterId);
            writer.WriteVaruhint(secondCharacterCurrentWeight);
            writer.WriteVaruhint(secondCharacterMaxWeight);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            firstCharacterId = reader.ReadInt();
            firstCharacterCurrentWeight = reader.ReadVaruhint();
            if (firstCharacterCurrentWeight < 0)
                throw new Exception("Forbidden value on firstCharacterCurrentWeight = " + firstCharacterCurrentWeight + ", it doesn't respect the following condition : firstCharacterCurrentWeight < 0");
            firstCharacterMaxWeight = reader.ReadVaruhint();
            if (firstCharacterMaxWeight < 0)
                throw new Exception("Forbidden value on firstCharacterMaxWeight = " + firstCharacterMaxWeight + ", it doesn't respect the following condition : firstCharacterMaxWeight < 0");
            secondCharacterId = reader.ReadInt();
            secondCharacterCurrentWeight = reader.ReadVaruhint();
            if (secondCharacterCurrentWeight < 0)
                throw new Exception("Forbidden value on secondCharacterCurrentWeight = " + secondCharacterCurrentWeight + ", it doesn't respect the following condition : secondCharacterCurrentWeight < 0");
            secondCharacterMaxWeight = reader.ReadVaruhint();
            if (secondCharacterMaxWeight < 0)
                throw new Exception("Forbidden value on secondCharacterMaxWeight = " + secondCharacterMaxWeight + ", it doesn't respect the following condition : secondCharacterMaxWeight < 0");
            

}


}


}