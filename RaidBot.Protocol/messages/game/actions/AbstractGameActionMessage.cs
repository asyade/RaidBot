


















// Generated on 06/26/2015 11:41:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AbstractGameActionMessage : NetworkMessage
{

public const uint Id = 1000;
public override uint MessageId
{
    get { return Id; }
}

public ushort actionId;
        public int sourceId;
        

public AbstractGameActionMessage()
{
}

public AbstractGameActionMessage(ushort actionId, int sourceId)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(actionId);
            writer.WriteInt(sourceId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

actionId = reader.ReadVaruhshort();
            if (actionId < 0)
                throw new Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            sourceId = reader.ReadInt();
            

}


}


}