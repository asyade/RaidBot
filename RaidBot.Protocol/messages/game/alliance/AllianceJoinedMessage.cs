


















// Generated on 06/26/2015 11:41:06
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceJoinedMessage : NetworkMessage
{

public const uint Id = 6402;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceInformations allianceInfo;
        public bool enabled;
        

public AllianceJoinedMessage()
{
}

public AllianceJoinedMessage(Types.AllianceInformations allianceInfo, bool enabled)
        {
            this.allianceInfo = allianceInfo;
            this.enabled = enabled;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

allianceInfo.Serialize(writer);
            writer.WriteBoolean(enabled);
            

}

public override void Deserialize(ICustomDataReader reader)
{

allianceInfo = new Types.AllianceInformations();
            allianceInfo.Deserialize(reader);
            enabled = reader.ReadBoolean();
            

}


}


}