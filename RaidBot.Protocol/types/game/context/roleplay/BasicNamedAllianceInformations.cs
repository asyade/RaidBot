


















// Generated on 06/26/2015 11:42:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class BasicNamedAllianceInformations : BasicAllianceInformations
{

public const short Id = 418;
public override short TypeId
{
    get { return Id; }
}

public string allianceName;
        

public BasicNamedAllianceInformations()
{
}

public BasicNamedAllianceInformations(uint allianceId, string allianceTag, string allianceName)
         : base(allianceId, allianceTag)
        {
            this.allianceName = allianceName;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(allianceName);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            allianceName = reader.ReadUTF();
            

}


}


}