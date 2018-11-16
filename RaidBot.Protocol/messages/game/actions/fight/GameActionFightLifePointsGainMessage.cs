


















// Generated on 06/26/2015 11:41:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameActionFightLifePointsGainMessage : AbstractGameActionMessage
{

public const uint Id = 6311;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        public uint delta;
        

public GameActionFightLifePointsGainMessage()
{
}

public GameActionFightLifePointsGainMessage(ushort actionId, int sourceId, int targetId, uint delta)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.delta = delta;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteVaruhint(delta);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            delta = reader.ReadVaruhint();
            if (delta < 0)
                throw new Exception("Forbidden value on delta = " + delta + ", it doesn't respect the following condition : delta < 0");
            

}


}


}