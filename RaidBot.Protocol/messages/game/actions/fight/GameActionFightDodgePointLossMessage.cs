


















// Generated on 06/26/2015 11:41:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightDodgePointLossMessage : AbstractGameActionMessage
{

public const uint Id = 5828;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public ushort amount;
        

public GameActionFightDodgePointLossMessage()
{
}

public GameActionFightDodgePointLossMessage(ushort actionId, int sourceId, int targetId, ushort amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteVaruhshort(amount);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            amount = reader.ReadVaruhshort();
            if (amount < 0)
                throw new Exception("Forbidden value on amount = " + amount + ", it doesn't respect the following condition : amount < 0");
            

}


}


}