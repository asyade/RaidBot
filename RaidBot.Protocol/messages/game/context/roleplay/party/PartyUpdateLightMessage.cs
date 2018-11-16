


















// Generated on 06/26/2015 11:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PartyUpdateLightMessage : AbstractPartyEventMessage
{

public const uint Id = 6054;
public override uint MessageId
{
    get { return Id; }
}

public uint id;
        public uint lifePoints;
        public uint maxLifePoints;
        public ushort prospecting;
        public byte regenRate;
        

public PartyUpdateLightMessage()
{
}

public PartyUpdateLightMessage(uint partyId, uint id, uint lifePoints, uint maxLifePoints, ushort prospecting, byte regenRate)
         : base(partyId)
        {
            this.id = id;
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.prospecting = prospecting;
            this.regenRate = regenRate;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(id);
            writer.WriteVaruhint(lifePoints);
            writer.WriteVaruhint(maxLifePoints);
            writer.WriteVaruhshort(prospecting);
            writer.WriteByte(regenRate);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            id = reader.ReadVaruhint();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            lifePoints = reader.ReadVaruhint();
            if (lifePoints < 0)
                throw new Exception("Forbidden value on lifePoints = " + lifePoints + ", it doesn't respect the following condition : lifePoints < 0");
            maxLifePoints = reader.ReadVaruhint();
            if (maxLifePoints < 0)
                throw new Exception("Forbidden value on maxLifePoints = " + maxLifePoints + ", it doesn't respect the following condition : maxLifePoints < 0");
            prospecting = reader.ReadVaruhshort();
            if (prospecting < 0)
                throw new Exception("Forbidden value on prospecting = " + prospecting + ", it doesn't respect the following condition : prospecting < 0");
            regenRate = reader.ReadByte();
            if (regenRate < 0 || regenRate > 255)
                throw new Exception("Forbidden value on regenRate = " + regenRate + ", it doesn't respect the following condition : regenRate < 0 || regenRate > 255");
            

}


}


}