


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class Idol
{

public const short Id = 489;
public virtual short TypeId
{
    get { return Id; }
}

public ushort id;
        public ushort xpBonusPercent;
        public ushort dropBonusPercent;
        

public Idol()
{
}

public Idol(ushort id, ushort xpBonusPercent, ushort dropBonusPercent)
        {
            this.id = id;
            this.xpBonusPercent = xpBonusPercent;
            this.dropBonusPercent = dropBonusPercent;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(id);
            writer.WriteVaruhshort(xpBonusPercent);
            writer.WriteVaruhshort(dropBonusPercent);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

id = reader.ReadVaruhshort();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            xpBonusPercent = reader.ReadVaruhshort();
            if (xpBonusPercent < 0)
                throw new Exception("Forbidden value on xpBonusPercent = " + xpBonusPercent + ", it doesn't respect the following condition : xpBonusPercent < 0");
            dropBonusPercent = reader.ReadVaruhshort();
            if (dropBonusPercent < 0)
                throw new Exception("Forbidden value on dropBonusPercent = " + dropBonusPercent + ", it doesn't respect the following condition : dropBonusPercent < 0");
            

}


}


}