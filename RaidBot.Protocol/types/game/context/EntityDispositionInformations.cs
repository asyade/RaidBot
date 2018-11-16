


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class EntityDispositionInformations
{

public const short Id = 60;
public virtual short TypeId
{
    get { return Id; }
}

public short cellId;
        public sbyte direction;
        

public EntityDispositionInformations()
{
}

public EntityDispositionInformations(short cellId, sbyte direction)
        {
            this.cellId = cellId;
            this.direction = direction;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(cellId);
            writer.WriteSByte(direction);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

cellId = reader.ReadShort();
            if (cellId < -1 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < -1 || cellId > 559");
            direction = reader.ReadSByte();
            if (direction < 0)
                throw new Exception("Forbidden value on direction = " + direction + ", it doesn't respect the following condition : direction < 0");
            

}


}


}