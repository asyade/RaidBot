


















// Generated on 06/26/2015 11:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStartOkMulticraftCustomerMessage : NetworkMessage
{

public const uint Id = 5817;
public override uint MessageId
{
    get { return Id; }
}

public uint skillId;
        public byte crafterJobLevel;
        

public ExchangeStartOkMulticraftCustomerMessage()
{
}

public ExchangeStartOkMulticraftCustomerMessage(uint skillId, byte crafterJobLevel)
        {
            this.skillId = skillId;
            this.crafterJobLevel = crafterJobLevel;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(skillId);
            writer.WriteByte(crafterJobLevel);
            

}

public override void Deserialize(ICustomDataReader reader)
{

skillId = reader.ReadVaruhint();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            crafterJobLevel = reader.ReadByte();
            if (crafterJobLevel < 0 || crafterJobLevel > 255)
                throw new Exception("Forbidden value on crafterJobLevel = " + crafterJobLevel + ", it doesn't respect the following condition : crafterJobLevel < 0 || crafterJobLevel > 255");
            

}


}


}