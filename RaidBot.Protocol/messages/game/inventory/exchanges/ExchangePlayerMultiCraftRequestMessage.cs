


















// Generated on 06/26/2015 11:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangePlayerMultiCraftRequestMessage : ExchangeRequestMessage
{

public const uint Id = 5784;
public override uint MessageId
{
    get { return Id; }
}

public uint target;
        public uint skillId;
        

public ExchangePlayerMultiCraftRequestMessage()
{
}

public ExchangePlayerMultiCraftRequestMessage(sbyte exchangeType, uint target, uint skillId)
         : base(exchangeType)
        {
            this.target = target;
            this.skillId = skillId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(target);
            writer.WriteVaruhint(skillId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            target = reader.ReadVaruhint();
            if (target < 0)
                throw new Exception("Forbidden value on target = " + target + ", it doesn't respect the following condition : target < 0");
            skillId = reader.ReadVaruhint();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}


}


}