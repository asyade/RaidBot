


















// Generated on 06/26/2015 11:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeStartOkCraftWithInformationMessage : ExchangeStartOkCraftMessage
{

public const uint Id = 5941;
public override uint MessageId
{
    get { return Id; }
}

public uint skillId;
        

public ExchangeStartOkCraftWithInformationMessage()
{
}

public ExchangeStartOkCraftWithInformationMessage(uint skillId)
        {
            this.skillId = skillId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(skillId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            skillId = reader.ReadVaruhint();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}


}


}