


















// Generated on 06/26/2015 11:41:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightLifeAndShieldPointsLostMessage : GameActionFightLifePointsLostMessage
{

public const uint Id = 6310;
public override uint MessageId
{
    get { return Id; }
}

public ushort shieldLoss;
        

public GameActionFightLifeAndShieldPointsLostMessage()
{
}

public GameActionFightLifeAndShieldPointsLostMessage(ushort actionId, int sourceId, int targetId, ushort loss, ushort permanentDamages, ushort shieldLoss)
         : base(actionId, sourceId, targetId, loss, permanentDamages)
        {
            this.shieldLoss = shieldLoss;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(shieldLoss);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            shieldLoss = reader.ReadVaruhshort();
            if (shieldLoss < 0)
                throw new Exception("Forbidden value on shieldLoss = " + shieldLoss + ", it doesn't respect the following condition : shieldLoss < 0");
            

}


}


}