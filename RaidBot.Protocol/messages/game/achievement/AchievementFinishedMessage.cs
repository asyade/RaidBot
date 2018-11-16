


















// Generated on 06/26/2015 11:41:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AchievementFinishedMessage : NetworkMessage
{

public const uint Id = 6208;
public override uint MessageId
{
    get { return Id; }
}

public ushort id;
        public byte finishedlevel;
        

public AchievementFinishedMessage()
{
}

public AchievementFinishedMessage(ushort id, byte finishedlevel)
        {
            this.id = id;
            this.finishedlevel = finishedlevel;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(id);
            writer.WriteByte(finishedlevel);
            

}

public override void Deserialize(ICustomDataReader reader)
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