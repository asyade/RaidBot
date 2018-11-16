


















// Generated on 06/26/2015 11:41:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightTriggerEffectMessage : GameActionFightDispellEffectMessage
{

public const uint Id = 6147;
public override uint MessageId
{
    get { return Id; }
}



public GameActionFightTriggerEffectMessage()
{
}

public GameActionFightTriggerEffectMessage(ushort actionId, int sourceId, int targetId, int boostUID)
         : base(actionId, sourceId, targetId, boostUID)
        {
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            

}


}


}