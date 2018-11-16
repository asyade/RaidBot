


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AbstractPartyMessage : NetworkMessage
{

public const uint Id = 6274;
public override uint MessageId
{
    get { return Id; }
}

public uint partyId;
        

public AbstractPartyMessage()
{
}

public AbstractPartyMessage(uint partyId)
        {
            this.partyId = partyId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(partyId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

partyId = reader.ReadVaruhint();
            if (partyId < 0)
                throw new Exception("Forbidden value on partyId = " + partyId + ", it doesn't respect the following condition : partyId < 0");
            

}


}


}