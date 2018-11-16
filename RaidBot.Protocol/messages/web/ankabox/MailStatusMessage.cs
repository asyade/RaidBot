


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class MailStatusMessage : NetworkMessage
{

public const uint Id = 6275;
public override uint MessageId
{
    get { return Id; }
}

public ushort unread;
        public ushort total;
        

public MailStatusMessage()
{
}

public MailStatusMessage(ushort unread, ushort total)
        {
            this.unread = unread;
            this.total = total;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(unread);
            writer.WriteVaruhshort(total);
            

}

public override void Deserialize(ICustomDataReader reader)
{

unread = reader.ReadVaruhshort();
            if (unread < 0)
                throw new Exception("Forbidden value on unread = " + unread + ", it doesn't respect the following condition : unread < 0");
            total = reader.ReadVaruhshort();
            if (total < 0)
                throw new Exception("Forbidden value on total = " + total + ", it doesn't respect the following condition : total < 0");
            

}


}


}