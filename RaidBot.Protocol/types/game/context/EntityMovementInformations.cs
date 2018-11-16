


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class EntityMovementInformations
{

public const short Id = 63;
public virtual short TypeId
{
    get { return Id; }
}

public int id;
        public sbyte[] steps;
        

public EntityMovementInformations()
{
}

public EntityMovementInformations(int id, sbyte[] steps)
        {
            this.id = id;
            this.steps = steps;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(id);
            writer.WriteUShort((ushort)steps.Length);
            foreach (var entry in steps)
            {
                 writer.WriteSByte(entry);
            }
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

id = reader.ReadInt();
            var limit = reader.ReadUShort();
            steps = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 steps[i] = reader.ReadSByte();
            }
            

}


}


}