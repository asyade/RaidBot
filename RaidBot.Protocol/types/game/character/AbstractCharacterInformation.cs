


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AbstractCharacterInformation
{

public const short Id = 400;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        

public AbstractCharacterInformation()
{
}

public AbstractCharacterInformation(uint id)
        {
            this.id = id;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(id);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

id = reader.ReadVaruhint();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}