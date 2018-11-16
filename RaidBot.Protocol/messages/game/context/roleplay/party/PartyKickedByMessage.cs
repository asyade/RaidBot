


















// Generated on 06/26/2015 11:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyKickedByMessage : AbstractPartyMessage
{

public const uint Id = 5590;
public override uint MessageId
{
    get { return Id; }
}

public uint kickerId;
        

public PartyKickedByMessage()
{
}

public PartyKickedByMessage(uint partyId, uint kickerId)
         : base(partyId)
        {
            this.kickerId = kickerId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(kickerId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            kickerId = reader.ReadVaruhint();
            if (kickerId < 0)
                throw new Exception("Forbidden value on kickerId = " + kickerId + ", it doesn't respect the following condition : kickerId < 0");
            

}


}


}