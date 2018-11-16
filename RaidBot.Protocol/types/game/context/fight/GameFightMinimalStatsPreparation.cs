


















// Generated on 06/26/2015 11:42:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameFightMinimalStatsPreparation : GameFightMinimalStats
{

public const short Id = 360;
public override short TypeId
{
    get { return Id; }
}

public uint initiative;
        

public GameFightMinimalStatsPreparation()
{
}

public GameFightMinimalStatsPreparation(uint lifePoints, uint maxLifePoints, uint baseMaxLifePoints, uint permanentDamagePercent, uint shieldPoints, short actionPoints, short maxActionPoints, short movementPoints, short maxMovementPoints, int summoner, bool summoned, short neutralElementResistPercent, short earthElementResistPercent, short waterElementResistPercent, short airElementResistPercent, short fireElementResistPercent, short neutralElementReduction, short earthElementReduction, short waterElementReduction, short airElementReduction, short fireElementReduction, short criticalDamageFixedResist, short pushDamageFixedResist, ushort dodgePALostProbability, ushort dodgePMLostProbability, short tackleBlock, short tackleEvade, sbyte invisibilityState, uint initiative)
         : base(lifePoints, maxLifePoints, baseMaxLifePoints, permanentDamagePercent, shieldPoints, actionPoints, maxActionPoints, movementPoints, maxMovementPoints, summoner, summoned, neutralElementResistPercent, earthElementResistPercent, waterElementResistPercent, airElementResistPercent, fireElementResistPercent, neutralElementReduction, earthElementReduction, waterElementReduction, airElementReduction, fireElementReduction, criticalDamageFixedResist, pushDamageFixedResist, dodgePALostProbability, dodgePMLostProbability, tackleBlock, tackleEvade, invisibilityState)
        {
            this.initiative = initiative;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(initiative);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            initiative = reader.ReadVaruhint();
            if (initiative < 0)
                throw new Exception("Forbidden value on initiative = " + initiative + ", it doesn't respect the following condition : initiative < 0");
            

}


}


}