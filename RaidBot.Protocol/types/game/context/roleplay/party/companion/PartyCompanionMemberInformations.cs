


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PartyCompanionMemberInformations : PartyCompanionBaseInformations
{

public const short Id = 452;
public override short TypeId
{
    get { return Id; }
}

public ushort initiative;
        public uint lifePoints;
        public uint maxLifePoints;
        public ushort prospecting;
        public byte regenRate;
        

public PartyCompanionMemberInformations()
{
}

public PartyCompanionMemberInformations(sbyte indexId, sbyte companionGenericId, Types.EntityLook entityLook, ushort initiative, uint lifePoints, uint maxLifePoints, ushort prospecting, byte regenRate)
         : base(indexId, companionGenericId, entityLook)
        {
            this.initiative = initiative;
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.prospecting = prospecting;
            this.regenRate = regenRate;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(initiative);
            writer.WriteVaruhint(lifePoints);
            writer.WriteVaruhint(maxLifePoints);
            writer.WriteVaruhshort(prospecting);
            writer.WriteByte(regenRate);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            initiative = reader.ReadVaruhshort();
            if (initiative < 0)
                throw new Exception("Forbidden value on initiative = " + initiative + ", it doesn't respect the following condition : initiative < 0");
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