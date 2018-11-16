


















// Generated on 06/26/2015 11:42:00
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ServerSessionConstantInteger : ServerSessionConstant
{

public const short Id = 433;
public override short TypeId
{
    get { return Id; }
}

public int value;
        

public ServerSessionConstantInteger()
{
}

public ServerSessionConstantInteger(ushort id, int value)
         : base(id)
        {
            this.value = value;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(value);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            value = reader.ReadInt();
            

}


}


}