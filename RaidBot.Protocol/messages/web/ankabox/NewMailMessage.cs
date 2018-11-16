


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class NewMailMessage : MailStatusMessage
{

public const uint Id = 6292;
public override uint MessageId
{
    get { return Id; }
}

public int[] sendersAccountId;
        

public NewMailMessage()
{
}

public NewMailMessage(ushort unread, ushort total, int[] sendersAccountId)
         : base(unread, total)
        {
            this.sendersAccountId = sendersAccountId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)sendersAccountId.Length);
            foreach (var entry in sendersAccountId)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            sendersAccountId = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 sendersAccountId[i] = reader.ReadInt();
            }
            

}


}


}