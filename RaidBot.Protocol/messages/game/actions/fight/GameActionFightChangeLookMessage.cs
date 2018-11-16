


















// Generated on 06/26/2015 11:41:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightChangeLookMessage : AbstractGameActionMessage
{

public const uint Id = 5532;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public Types.EntityLook entityLook;
        

public GameActionFightChangeLookMessage()
{
}

public GameActionFightChangeLookMessage(ushort actionId, int sourceId, int targetId, Types.EntityLook entityLook)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.entityLook = entityLook;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            entityLook.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
            

}


}


}