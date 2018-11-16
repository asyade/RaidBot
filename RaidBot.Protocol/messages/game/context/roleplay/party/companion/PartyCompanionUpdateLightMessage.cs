


















// Generated on 06/26/2015 11:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyCompanionUpdateLightMessage : PartyUpdateLightMessage
{

public const uint Id = 6472;
public override uint MessageId
{
    get { return Id; }
}

public sbyte indexId;
        

public PartyCompanionUpdateLightMessage()
{
}

public PartyCompanionUpdateLightMessage(uint partyId, uint id, uint lifePoints, uint maxLifePoints, ushort prospecting, byte regenRate, sbyte indexId)
         : base(partyId, id, lifePoints, maxLifePoints, prospecting, regenRate)
        {
            this.indexId = indexId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(indexId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            indexId = reader.ReadSByte();
            if (indexId < 0)
                throw new Exception("Forbidden value on indexId = " + indexId + ", it doesn't respect the following condition : indexId < 0");
            

}


}


}