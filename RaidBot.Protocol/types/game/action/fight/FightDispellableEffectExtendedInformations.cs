


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightDispellableEffectExtendedInformations
{

public const short Id = 208;
public virtual short TypeId
{
    get { return Id; }
}

public ushort actionId;
        public int sourceId;
        public Types.AbstractFightDispellableEffect effect;
        

public FightDispellableEffectExtendedInformations()
{
}

public FightDispellableEffectExtendedInformations(ushort actionId, int sourceId, Types.AbstractFightDispellableEffect effect)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
            this.effect = effect;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(actionId);
            writer.WriteInt(sourceId);
            writer.WriteShort(effect.TypeId);
            effect.Serialize(writer);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

actionId = reader.ReadVaruhshort();
            if (actionId < 0)
                throw new Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            sourceId = reader.ReadInt();
            effect = Types.ProtocolTypeManager.GetInstance<Types.AbstractFightDispellableEffect>(reader.ReadShort());
            effect.Deserialize(reader);
            

}


}


}