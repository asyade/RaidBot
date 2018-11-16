


















// Generated on 06/26/2015 11:41:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightDispellableEffectMessage : AbstractGameActionMessage
{

public const uint Id = 6070;
public override uint MessageId
{
    get { return Id; }
}

public Types.AbstractFightDispellableEffect effect;
        

public GameActionFightDispellableEffectMessage()
{
}

public GameActionFightDispellableEffectMessage(ushort actionId, int sourceId, Types.AbstractFightDispellableEffect effect)
         : base(actionId, sourceId)
        {
            this.effect = effect;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(effect.TypeId);
            effect.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            effect = Types.ProtocolTypeManager.GetInstance<Types.AbstractFightDispellableEffect>(reader.ReadShort());
            effect.Deserialize(reader);
            

}


}


}