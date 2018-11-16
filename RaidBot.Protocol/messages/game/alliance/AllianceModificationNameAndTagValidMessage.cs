


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceModificationNameAndTagValidMessage : NetworkMessage
{

public const uint Id = 6449;
public override uint MessageId
{
    get { return Id; }
}

public string allianceName;
        public string allianceTag;
        

public AllianceModificationNameAndTagValidMessage()
{
}

public AllianceModificationNameAndTagValidMessage(string allianceName, string allianceTag)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
            

}

public override void Deserialize(ICustomDataReader reader)
{

allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
            

}


}


}