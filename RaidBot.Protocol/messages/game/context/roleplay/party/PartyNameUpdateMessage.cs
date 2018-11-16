


















// Generated on 06/26/2015 11:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyNameUpdateMessage : AbstractPartyMessage
{

public const uint Id = 6502;
public override uint MessageId
{
    get { return Id; }
}

public string partyName;
        

public PartyNameUpdateMessage()
{
}

public PartyNameUpdateMessage(uint partyId, string partyName)
         : base(partyId)
        {
            this.partyName = partyName;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(partyName);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            partyName = reader.ReadUTF();
            

}


}


}