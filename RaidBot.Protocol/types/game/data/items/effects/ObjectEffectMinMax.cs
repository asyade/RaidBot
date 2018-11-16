


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class ObjectEffectMinMax : ObjectEffect
{

public const short Id = 82;
public override short TypeId
{
    get { return Id; }
}

public uint min;
        public uint max;
        

public ObjectEffectMinMax()
{
}

public ObjectEffectMinMax(ushort actionId, uint min, uint max)
         : base(actionId)
        {
            this.min = min;
            this.max = max;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(min);
            writer.WriteVaruhint(max);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            min = reader.ReadVaruhint();
            if (min < 0)
                throw new Exception("Forbidden value on min = " + min + ", it doesn't respect the following condition : min < 0");
            max = reader.ReadVaruhint();
            if (max < 0)
                throw new Exception("Forbidden value on max = " + max + ", it doesn't respect the following condition : max < 0");
            

}


}


}