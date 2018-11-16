


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class UpdateMountIntBoost : UpdateMountBoost
{

public const short Id = 357;
public override short TypeId
{
    get { return Id; }
}

public int value;
        

public UpdateMountIntBoost()
{
}

public UpdateMountIntBoost(sbyte type, int value)
         : base(type)
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