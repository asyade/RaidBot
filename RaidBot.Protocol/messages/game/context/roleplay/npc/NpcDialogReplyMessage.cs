


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class NpcDialogReplyMessage : NetworkMessage
{

public const uint Id = 5616;
public override uint MessageId
{
    get { return Id; }
}

public ushort replyId;
        

public NpcDialogReplyMessage()
{
}

public NpcDialogReplyMessage(ushort replyId)
        {
            this.replyId = replyId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(replyId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

replyId = reader.ReadVaruhshort();
            if (replyId < 0)
                throw new Exception("Forbidden value on replyId = " + replyId + ", it doesn't respect the following condition : replyId < 0");
            

}


}


}