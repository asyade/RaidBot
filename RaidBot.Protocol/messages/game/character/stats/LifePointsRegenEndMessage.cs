


















// Generated on 06/26/2015 11:41:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class LifePointsRegenEndMessage : UpdateLifePointsMessage
{

public const uint Id = 5686;
public override uint MessageId
{
    get { return Id; }
}

public uint lifePointsGained;
        

public LifePointsRegenEndMessage()
{
}

public LifePointsRegenEndMessage(uint lifePoints, uint maxLifePoints, uint lifePointsGained)
         : base(lifePoints, maxLifePoints)
        {
            this.lifePointsGained = lifePointsGained;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(lifePointsGained);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            lifePointsGained = reader.ReadVaruhint();
            if (lifePointsGained < 0)
                throw new Exception("Forbidden value on lifePointsGained = " + lifePointsGained + ", it doesn't respect the following condition : lifePointsGained < 0");
            

}


}


}