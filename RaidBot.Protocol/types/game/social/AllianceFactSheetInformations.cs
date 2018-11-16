


















// Generated on 06/26/2015 11:42:11
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AllianceFactSheetInformations : AllianceInformations
{

public const short Id = 421;
public override short TypeId
{
    get { return Id; }
}

public int creationDate;
        

public AllianceFactSheetInformations()
{
}

public AllianceFactSheetInformations(uint allianceId, string allianceTag, string allianceName, Types.GuildEmblem allianceEmblem, int creationDate)
         : base(allianceId, allianceTag, allianceName, allianceEmblem)
        {
            this.creationDate = creationDate;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(creationDate);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            creationDate = reader.ReadInt();
            if (creationDate < 0)
                throw new Exception("Forbidden value on creationDate = " + creationDate + ", it doesn't respect the following condition : creationDate < 0");
            

}


}


}