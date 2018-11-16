


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightResultMutantListEntry : FightResultFighterListEntry
{

public const short Id = 216;
public override short TypeId
{
    get { return Id; }
}

public ushort level;
        

public FightResultMutantListEntry()
{
}

public FightResultMutantListEntry(ushort outcome, sbyte wave, Types.FightLoot rewards, int id, bool alive, ushort level)
         : base(outcome, wave, rewards, id, alive)
        {
            this.level = level;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(level);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            level = reader.ReadVaruhshort();
            if (level < 0)
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 0");
            

}


}


}