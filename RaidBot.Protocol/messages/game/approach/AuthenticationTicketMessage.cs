


















// Generated on 06/26/2015 11:41:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AuthenticationTicketMessage : NetworkMessage
{

public const uint Id = 110;
public override uint MessageId
{
    get { return Id; }
}

public string lang;
public string ticket;
        

public AuthenticationTicketMessage()
{
}

public AuthenticationTicketMessage(string lang, string ticket)
        {
            this.lang = lang;
            this.ticket = ticket;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(lang);
writer.WriteUTF(ticket);
            

}

public override void Deserialize(ICustomDataReader reader)
{

lang = reader.ReadUTF();
ticket = reader.ReadUTF();
            

}


}


}