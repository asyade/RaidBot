


















// Generated on 06/26/2015 11:41:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionAcknowledgementMessage : NetworkMessage
{

public const uint Id = 957;
public override uint MessageId
{
    get { return Id; }
}

public bool valid;
        public sbyte actionId;
        

public GameActionAcknowledgementMessage()
{
}

public GameActionAcknowledgementMessage(bool valid, sbyte actionId)
        {
            this.valid = valid;
            this.actionId = actionId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(valid);
            writer.WriteSByte(actionId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

valid = reader.ReadBoolean();
            actionId = reader.ReadSByte();
            

}


}


}