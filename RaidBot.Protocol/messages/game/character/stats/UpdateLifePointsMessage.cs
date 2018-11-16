


















// Generated on 06/26/2015 11:41:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class UpdateLifePointsMessage : NetworkMessage
{

public const uint Id = 5658;
public override uint MessageId
{
    get { return Id; }
}

public uint lifePoints;
        public uint maxLifePoints;
        

public UpdateLifePointsMessage()
{
}

public UpdateLifePointsMessage(uint lifePoints, uint maxLifePoints)
        {
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(lifePoints);
            writer.WriteVaruhint(maxLifePoints);
            

}

public override void Deserialize(ICustomDataReader reader)
{

lifePoints = reader.ReadVaruhint();
            if (lifePoints < 0)
                throw new Exception("Forbidden value on lifePoints = " + lifePoints + ", it doesn't respect the following condition : lifePoints < 0");
            maxLifePoints = reader.ReadVaruhint();
            if (maxLifePoints < 0)
                throw new Exception("Forbidden value on maxLifePoints = " + maxLifePoints + ", it doesn't respect the following condition : maxLifePoints < 0");
            

}


}


}