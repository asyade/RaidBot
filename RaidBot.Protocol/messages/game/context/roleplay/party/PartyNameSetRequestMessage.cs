


















// Generated on 06/26/2015 11:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyNameSetRequestMessage : AbstractPartyMessage
{

public const uint Id = 6503;
public override uint MessageId
{
    get { return Id; }
}

public string partyName;
        

public PartyNameSetRequestMessage()
{
}

public PartyNameSetRequestMessage(uint partyId, string partyName)
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