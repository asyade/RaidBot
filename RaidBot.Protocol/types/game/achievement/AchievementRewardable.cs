


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AchievementRewardable
{

public const short Id = 412;
public virtual short TypeId
{
    get { return Id; }
}

public ushort id;
        public byte finishedlevel;
        

public AchievementRewardable()
{
}

public AchievementRewardable(ushort id, byte finishedlevel)
        {
            this.id = id;
            this.finishedlevel = finishedlevel;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(id);
            writer.WriteByte(finishedlevel);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

id = reader.ReadVaruhshort();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            finishedlevel = reader.ReadByte();
            if (finishedlevel < 0 || finishedlevel > 200)
                throw new Exception("Forbidden value on finishedlevel = " + finishedlevel + ", it doesn't respect the following condition : finishedlevel < 0 || finishedlevel > 200");
            

}


}


}