


















// Generated on 06/26/2015 11:42:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class HumanOptionOrnament : HumanOption
{

public const short Id = 411;
public override short TypeId
{
    get { return Id; }
}

public ushort ornamentId;
        

public HumanOptionOrnament()
{
}

public HumanOptionOrnament(ushort ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(ornamentId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            ornamentId = reader.ReadVaruhshort();
            if (ornamentId < 0)
                throw new Exception("Forbidden value on ornamentId = " + ornamentId + ", it doesn't respect the following condition : ornamentId < 0");
            

}


}


}