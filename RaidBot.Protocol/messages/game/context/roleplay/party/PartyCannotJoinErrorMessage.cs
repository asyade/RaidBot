


















// Generated on 06/26/2015 11:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyCannotJoinErrorMessage : AbstractPartyMessage
{

public const uint Id = 5583;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public PartyCannotJoinErrorMessage()
{
}

public PartyCannotJoinErrorMessage(uint partyId, sbyte reason)
         : base(partyId)
        {
            this.reason = reason;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(reason);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            

}


}


}