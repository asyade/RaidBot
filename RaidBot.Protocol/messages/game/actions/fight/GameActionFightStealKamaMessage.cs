


















// Generated on 06/26/2015 11:41:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightStealKamaMessage : AbstractGameActionMessage
{

public const uint Id = 5535;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public uint amount;
        

public GameActionFightStealKamaMessage()
{
}

public GameActionFightStealKamaMessage(ushort actionId, int sourceId, int targetId, uint amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteVaruhint(amount);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            amount = reader.ReadVaruhint();
            if (amount < 0)
                throw new Exception("Forbidden value on amount = " + amount + ", it doesn't respect the following condition : amount < 0");
            

}


}


}