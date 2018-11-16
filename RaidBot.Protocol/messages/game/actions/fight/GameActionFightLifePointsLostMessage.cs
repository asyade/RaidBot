


















// Generated on 06/26/2015 11:41:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightLifePointsLostMessage : AbstractGameActionMessage
{

public const uint Id = 6312;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public ushort loss;
        public ushort permanentDamages;
        

public GameActionFightLifePointsLostMessage()
{
}

public GameActionFightLifePointsLostMessage(ushort actionId, int sourceId, int targetId, ushort loss, ushort permanentDamages)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.loss = loss;
            this.permanentDamages = permanentDamages;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteVaruhshort(loss);
            writer.WriteVaruhshort(permanentDamages);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            loss = reader.ReadVaruhshort();
            if (loss < 0)
                throw new Exception("Forbidden value on loss = " + loss + ", it doesn't respect the following condition : loss < 0");
            permanentDamages = reader.ReadVaruhshort();
            if (permanentDamages < 0)
                throw new Exception("Forbidden value on permanentDamages = " + permanentDamages + ", it doesn't respect the following condition : permanentDamages < 0");
            

}


}


}