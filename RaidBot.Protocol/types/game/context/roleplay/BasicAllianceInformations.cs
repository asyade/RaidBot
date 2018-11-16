


















// Generated on 06/26/2015 11:42:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class BasicAllianceInformations : AbstractSocialGroupInfos
{

public const short Id = 419;
public override short TypeId
{
    get { return Id; }
}

public uint allianceId;
        public string allianceTag;
        

public BasicAllianceInformations()
{
}

public BasicAllianceInformations(uint allianceId, string allianceTag)
        {
            this.allianceId = allianceId;
            this.allianceTag = allianceTag;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhint(allianceId);
            writer.WriteUTF(allianceTag);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            allianceId = reader.ReadVaruhint();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            allianceTag = reader.ReadUTF();
            

}


}


}