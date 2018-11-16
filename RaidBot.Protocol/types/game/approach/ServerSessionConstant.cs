


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ServerSessionConstant
{

public const short Id = 430;
public virtual short TypeId
{
    get { return Id; }
}

public ushort id;
        

public ServerSessionConstant()
{
}

public ServerSessionConstant(ushort id)
        {
            this.id = id;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(id);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

id = reader.ReadVaruhshort();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}