


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ServerSessionConstantString : ServerSessionConstant
{

public const short Id = 436;
public override short TypeId
{
    get { return Id; }
}

public string value;
        

public ServerSessionConstantString()
{
}

public ServerSessionConstantString(ushort id, string value)
         : base(id)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(value);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadUTF();
            

}


}


}