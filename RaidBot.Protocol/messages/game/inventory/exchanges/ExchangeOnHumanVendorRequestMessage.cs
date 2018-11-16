


















// Generated on 06/26/2015 11:41:46
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeOnHumanVendorRequestMessage : NetworkMessage
{

public const uint Id = 5772;
public override uint MessageId
{
    get { return Id; }
}

public uint humanVendorId;
        public ushort humanVendorCell;
        

public ExchangeOnHumanVendorRequestMessage()
{
}

public ExchangeOnHumanVendorRequestMessage(uint humanVendorId, ushort humanVendorCell)
        {
            this.humanVendorId = humanVendorId;
            this.humanVendorCell = humanVendorCell;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(humanVendorId);
            writer.WriteVaruhshort(humanVendorCell);
            

}

public override void Deserialize(ICustomDataReader reader)
{

humanVendorId = reader.ReadVaruhint();
            if (humanVendorId < 0)
                throw new Exception("Forbidden value on humanVendorId = " + humanVendorId + ", it doesn't respect the following condition : humanVendorId < 0");
            humanVendorCell = reader.ReadVaruhshort();
            if (humanVendorCell < 0 || humanVendorCell > 559)
                throw new Exception("Forbidden value on humanVendorCell = " + humanVendorCell + ", it doesn't respect the following condition : humanVendorCell < 0 || humanVendorCell > 559");
            

}


}


}