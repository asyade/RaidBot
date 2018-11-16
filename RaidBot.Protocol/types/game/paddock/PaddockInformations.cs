


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PaddockInformations
{

public const short Id = 132;
public virtual short TypeId
{
    get { return Id; }
}

public ushort maxOutdoorMount;
        public ushort maxItems;
        

public PaddockInformations()
{
}

public PaddockInformations(ushort maxOutdoorMount, ushort maxItems)
        {
            this.maxOutdoorMount = maxOutdoorMount;
            this.maxItems = maxItems;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(maxOutdoorMount);
            writer.WriteVaruhshort(maxItems);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

maxOutdoorMount = reader.ReadVaruhshort();
            if (maxOutdoorMount < 0)
                throw new Exception("Forbidden value on maxOutdoorMount = " + maxOutdoorMount + ", it doesn't respect the following condition : maxOutdoorMount < 0");
            maxItems = reader.ReadVaruhshort();
            if (maxItems < 0)
                throw new Exception("Forbidden value on maxItems = " + maxItems + ", it doesn't respect the following condition : maxItems < 0");
            

}


}


}