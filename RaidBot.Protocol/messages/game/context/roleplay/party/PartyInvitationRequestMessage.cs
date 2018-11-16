


















// Generated on 06/26/2015 11:41:30
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyInvitationRequestMessage : NetworkMessage
{

public const uint Id = 5585;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        

public PartyInvitationRequestMessage()
{
}

public PartyInvitationRequestMessage(string name)
        {
            this.name = name;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(name);
            

}

public override void Deserialize(ICustomDataReader reader)
{

name = reader.ReadUTF();
            

}


}


}