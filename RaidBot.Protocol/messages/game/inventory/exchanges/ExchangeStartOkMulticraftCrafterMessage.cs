


















// Generated on 06/26/2015 11:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStartOkMulticraftCrafterMessage : NetworkMessage
{

public const uint Id = 5818;
public override uint MessageId
{
    get { return Id; }
}

public uint skillId;
        

public ExchangeStartOkMulticraftCrafterMessage()
{
}

public ExchangeStartOkMulticraftCrafterMessage(uint skillId)
        {
            this.skillId = skillId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(skillId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

skillId = reader.ReadVaruhint();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}


}


}