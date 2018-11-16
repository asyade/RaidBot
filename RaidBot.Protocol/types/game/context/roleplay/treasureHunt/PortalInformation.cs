


















// Generated on 06/26/2015 11:42:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PortalInformation
{

public const short Id = 466;
public virtual short TypeId
{
    get { return Id; }
}

public ushort portalId;
        public short areaId;
        

public PortalInformation()
{
}

public PortalInformation(ushort portalId, short areaId)
        {
            this.portalId = portalId;
            this.areaId = areaId;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(portalId);
            writer.WriteShort(areaId);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

portalId = reader.ReadVaruhshort();
            if (portalId < 0)
                throw new Exception("Forbidden value on portalId = " + portalId + ", it doesn't respect the following condition : portalId < 0");
            areaId = reader.ReadShort();
            

}


}


}