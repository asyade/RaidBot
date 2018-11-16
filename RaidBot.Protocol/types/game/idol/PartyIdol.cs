


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PartyIdol : Idol
{

public const short Id = 490;
public override short TypeId
{
    get { return Id; }
}

public int[] ownersIds;
        

public PartyIdol()
{
}

public PartyIdol(ushort id, ushort xpBonusPercent, ushort dropBonusPercent, int[] ownersIds)
         : base(id, xpBonusPercent, dropBonusPercent)
        {
            this.ownersIds = ownersIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)ownersIds.Length);
            foreach (var entry in ownersIds)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            ownersIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 ownersIds[i] = reader.ReadInt();
            }
            

}


}


}