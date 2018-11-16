


















// Generated on 06/26/2015 11:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeOkMultiCraftMessage : NetworkMessage
{

public const uint Id = 5768;
public override uint MessageId
{
    get { return Id; }
}

public uint initiatorId;
        public uint otherId;
        public sbyte role;
        

public ExchangeOkMultiCraftMessage()
{
}

public ExchangeOkMultiCraftMessage(uint initiatorId, uint otherId, sbyte role)
        {
            this.initiatorId = initiatorId;
            this.otherId = otherId;
            this.role = role;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(initiatorId);
            writer.WriteVaruhint(otherId);
            writer.WriteSByte(role);
            

}

public override void Deserialize(ICustomDataReader reader)
{

initiatorId = reader.ReadVaruhint();
            if (initiatorId < 0)
                throw new Exception("Forbidden value on initiatorId = " + initiatorId + ", it doesn't respect the following condition : initiatorId < 0");
            otherId = reader.ReadVaruhint();
            if (otherId < 0)
                throw new Exception("Forbidden value on otherId = " + otherId + ", it doesn't respect the following condition : otherId < 0");
            role = reader.ReadSByte();
            

}


}


}