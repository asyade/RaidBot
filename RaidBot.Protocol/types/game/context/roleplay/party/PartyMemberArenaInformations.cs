


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PartyMemberArenaInformations : PartyMemberInformations
{

public const short Id = 391;
public override short TypeId
{
    get { return Id; }
}

public ushort rank;
        

public PartyMemberArenaInformations()
{
}

public PartyMemberArenaInformations(uint id, byte level, string name, Types.EntityLook entityLook, sbyte breed, bool sex, uint lifePoints, uint maxLifePoints, ushort prospecting, byte regenRate, ushort initiative, sbyte alignmentSide, short worldX, short worldY, int mapId, ushort subAreaId, Types.PlayerStatus status, Types.PartyCompanionMemberInformations[] companions, ushort rank)
         : base(id, level, name, entityLook, breed, sex, lifePoints, maxLifePoints, prospecting, regenRate, initiative, alignmentSide, worldX, worldY, mapId, subAreaId, status, companions)
        {
            this.rank = rank;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(rank);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            rank = reader.ReadVaruhshort();
            if (rank < 0 || rank > 2300)
                throw new Exception("Forbidden value on rank = " + rank + ", it doesn't respect the following condition : rank < 0 || rank > 2300");
            

}


}


}