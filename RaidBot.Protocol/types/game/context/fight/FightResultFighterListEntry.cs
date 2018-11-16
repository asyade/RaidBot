


















// Generated on 06/26/2015 11:42:02
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightResultFighterListEntry : FightResultListEntry
{

public const short Id = 189;
public override short TypeId
{
    get { return Id; }
}

public int id;
        public bool alive;
        

public FightResultFighterListEntry()
{
}

public FightResultFighterListEntry(ushort outcome, sbyte wave, Types.FightLoot rewards, int id, bool alive)
         : base(outcome, wave, rewards)
        {
            this.id = id;
            this.alive = alive;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(id);
            writer.WriteBoolean(alive);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            id = reader.ReadInt();
            alive = reader.ReadBoolean();
            

}


}


}