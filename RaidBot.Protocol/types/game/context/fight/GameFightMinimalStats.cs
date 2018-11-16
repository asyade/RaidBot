


















// Generated on 06/26/2015 11:42:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameFightMinimalStats
{

public const short Id = 31;
public virtual short TypeId
{
    get { return Id; }
}

public uint lifePoints;
        public uint maxLifePoints;
        public uint baseMaxLifePoints;
        public uint permanentDamagePercent;
        public uint shieldPoints;
        public short actionPoints;
        public short maxActionPoints;
        public short movementPoints;
        public short maxMovementPoints;
        public int summoner;
        public bool summoned;
        public short neutralElementResistPercent;
        public short earthElementResistPercent;
        public short waterElementResistPercent;
        public short airElementResistPercent;
        public short fireElementResistPercent;
        public short neutralElementReduction;
        public short earthElementReduction;
        public short waterElementReduction;
        public short airElementReduction;
        public short fireElementReduction;
        public short criticalDamageFixedResist;
        public short pushDamageFixedResist;
        public ushort dodgePALostProbability;
        public ushort dodgePMLostProbability;
        public short tackleBlock;
        public short tackleEvade;
        public sbyte invisibilityState;
        

public GameFightMinimalStats()
{
}

public GameFightMinimalStats(uint lifePoints, uint maxLifePoints, uint baseMaxLifePoints, uint permanentDamagePercent, uint shieldPoints, short actionPoints, short maxActionPoints, short movementPoints, short maxMovementPoints, int summoner, bool summoned, short neutralElementResistPercent, short earthElementResistPercent, short waterElementResistPercent, short airElementResistPercent, short fireElementResistPercent, short neutralElementReduction, short earthElementReduction, short waterElementReduction, short airElementReduction, short fireElementReduction, short criticalDamageFixedResist, short pushDamageFixedResist, ushort dodgePALostProbability, ushort dodgePMLostProbability, short tackleBlock, short tackleEvade, sbyte invisibilityState)
        {
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.baseMaxLifePoints = baseMaxLifePoints;
            this.permanentDamagePercent = permanentDamagePercent;
            this.shieldPoints = shieldPoints;
            this.actionPoints = actionPoints;
            this.maxActionPoints = maxActionPoints;
            this.movementPoints = movementPoints;
            this.maxMovementPoints = maxMovementPoints;
            this.summoner = summoner;
            this.summoned = summoned;
            this.neutralElementResistPercent = neutralElementResistPercent;
            this.earthElementResistPercent = earthElementResistPercent;
            this.waterElementResistPercent = waterElementResistPercent;
            this.airElementResistPercent = airElementResistPercent;
            this.fireElementResistPercent = fireElementResistPercent;
            this.neutralElementReduction = neutralElementReduction;
            this.earthElementReduction = earthElementReduction;
            this.waterElementReduction = waterElementReduction;
            this.airElementReduction = airElementReduction;
            this.fireElementReduction = fireElementReduction;
            this.criticalDamageFixedResist = criticalDamageFixedResist;
            this.pushDamageFixedResist = pushDamageFixedResist;
            this.dodgePALostProbability = dodgePALostProbability;
            this.dodgePMLostProbability = dodgePMLostProbability;
            this.tackleBlock = tackleBlock;
            this.tackleEvade = tackleEvade;
            this.invisibilityState = invisibilityState;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(lifePoints);
            writer.WriteVaruhint(maxLifePoints);
            writer.WriteVaruhint(baseMaxLifePoints);
            writer.WriteVaruhint(permanentDamagePercent);
            writer.WriteVaruhint(shieldPoints);
            writer.WriteVarshort(actionPoints);
            writer.WriteVarshort(maxActionPoints);
            writer.WriteVarshort(movementPoints);
            writer.WriteVarshort(maxMovementPoints);
            writer.WriteInt(summoner);
            writer.WriteBoolean(summoned);
            writer.WriteVarshort(neutralElementResistPercent);
            writer.WriteVarshort(earthElementResistPercent);
            writer.WriteVarshort(waterElementResistPercent);
            writer.WriteVarshort(airElementResistPercent);
            writer.WriteVarshort(fireElementResistPercent);
            writer.WriteVarshort(neutralElementReduction);
            writer.WriteVarshort(earthElementReduction);
            writer.WriteVarshort(waterElementReduction);
            writer.WriteVarshort(airElementReduction);
            writer.WriteVarshort(fireElementReduction);
            writer.WriteVarshort(criticalDamageFixedResist);
            writer.WriteVarshort(pushDamageFixedResist);
            writer.WriteVaruhshort(dodgePALostProbability);
            writer.WriteVaruhshort(dodgePMLostProbability);
            writer.WriteVarshort(tackleBlock);
            writer.WriteVarshort(tackleEvade);
            writer.WriteSByte(invisibilityState);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

lifePoints = reader.ReadVaruhint();
            if (lifePoints < 0)
                throw new Exception("Forbidden value on lifePoints = " + lifePoints + ", it doesn't respect the following condition : lifePoints < 0");
            maxLifePoints = reader.ReadVaruhint();
            if (maxLifePoints < 0)
                throw new Exception("Forbidden value on maxLifePoints = " + maxLifePoints + ", it doesn't respect the following condition : maxLifePoints < 0");
            baseMaxLifePoints = reader.ReadVaruhint();
            if (baseMaxLifePoints < 0)
                throw new Exception("Forbidden value on baseMaxLifePoints = " + baseMaxLifePoints + ", it doesn't respect the following condition : baseMaxLifePoints < 0");
            permanentDamagePercent = reader.ReadVaruhint();
            if (permanentDamagePercent < 0)
                throw new Exception("Forbidden value on permanentDamagePercent = " + permanentDamagePercent + ", it doesn't respect the following condition : permanentDamagePercent < 0");
            shieldPoints = reader.ReadVaruhint();
            if (shieldPoints < 0)
                throw new Exception("Forbidden value on shieldPoints = " + shieldPoints + ", it doesn't respect the following condition : shieldPoints < 0");
            actionPoints = reader.ReadVarshort();
            maxActionPoints = reader.ReadVarshort();
            movementPoints = reader.ReadVarshort();
            maxMovementPoints = reader.ReadVarshort();
            summoner = reader.ReadInt();
            summoned = reader.ReadBoolean();
            neutralElementResistPercent = reader.ReadVarshort();
            earthElementResistPercent = reader.ReadVarshort();
            waterElementResistPercent = reader.ReadVarshort();
            airElementResistPercent = reader.ReadVarshort();
            fireElementResistPercent = reader.ReadVarshort();
            neutralElementReduction = reader.ReadVarshort();
            earthElementReduction = reader.ReadVarshort();
            waterElementReduction = reader.ReadVarshort();
            airElementReduction = reader.ReadVarshort();
            fireElementReduction = reader.ReadVarshort();
            criticalDamageFixedResist = reader.ReadVarshort();
            pushDamageFixedResist = reader.ReadVarshort();
            dodgePALostProbability = reader.ReadVaruhshort();
            if (dodgePALostProbability < 0)
                throw new Exception("Forbidden value on dodgePALostProbability = " + dodgePALostProbability + ", it doesn't respect the following condition : dodgePALostProbability < 0");
            dodgePMLostProbability = reader.ReadVaruhshort();
            if (dodgePMLostProbability < 0)
                throw new Exception("Forbidden value on dodgePMLostProbability = " + dodgePMLostProbability + ", it doesn't respect the following condition : dodgePMLostProbability < 0");
            tackleBlock = reader.ReadVarshort();
            tackleEvade = reader.ReadVarshort();
            invisibilityState = reader.ReadSByte();
            if (invisibilityState < 0)
                throw new Exception("Forbidden value on invisibilityState = " + invisibilityState + ", it doesn't respect the following condition : invisibilityState < 0");
            

}


}


}