


















// Generated on 06/26/2015 11:41:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AbstractGameActionWithAckMessage : AbstractGameActionMessage
{

public const uint Id = 1001;
public override uint MessageId
{
    get { return Id; }
}

public short waitAckId;
        

public AbstractGameActionWithAckMessage()
{
}

public AbstractGameActionWithAckMessage(ushort actionId, int sourceId, short waitAckId)
         : base(actionId, sourceId)
        {
            this.waitAckId = waitAckId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(waitAckId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            waitAckId = reader.ReadShort();
            

}


}


}