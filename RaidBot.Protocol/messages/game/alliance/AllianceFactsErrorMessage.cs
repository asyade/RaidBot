


















// Generated on 06/26/2015 11:41:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceFactsErrorMessage : NetworkMessage
{

public const uint Id = 6423;
public override uint MessageId
{
    get { return Id; }
}

public uint allianceId;
        

public AllianceFactsErrorMessage()
{
}

public AllianceFactsErrorMessage(uint allianceId)
        {
            this.allianceId = allianceId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(allianceId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

allianceId = reader.ReadVaruhint();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            

}


}


}