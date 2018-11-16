


















// Generated on 06/26/2015 11:42:10
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class PrismSubareaEmptyInfo
{

public const short Id = 438;
public virtual short TypeId
{
    get { return Id; }
}

public ushort subAreaId;
        public uint allianceId;
        

public PrismSubareaEmptyInfo()
{
}

public PrismSubareaEmptyInfo(ushort subAreaId, uint allianceId)
        {
            this.subAreaId = subAreaId;
            this.allianceId = allianceId;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(subAreaId);
            writer.WriteVaruhint(allianceId);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

subAreaId = reader.ReadVaruhshort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            allianceId = reader.ReadVaruhint();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            

}


}


}