


















// Generated on 06/26/2015 11:42:03
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class GameFightFighterMonsterLightInformations : GameFightFighterLightInformations
{

public const short Id = 455;
public override short TypeId
{
    get { return Id; }
}

public ushort creatureGenericId;
        

public GameFightFighterMonsterLightInformations()
{
}

public GameFightFighterMonsterLightInformations(bool sex, bool alive, int id, sbyte wave, ushort level, sbyte breed, ushort creatureGenericId)
         : base(sex, alive, id, wave, level, breed)
        {
            this.creatureGenericId = creatureGenericId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(creatureGenericId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            creatureGenericId = reader.ReadVaruhshort();
            if (creatureGenericId < 0)
                throw new Exception("Forbidden value on creatureGenericId = " + creatureGenericId + ", it doesn't respect the following condition : creatureGenericId < 0");
            

}


}


}