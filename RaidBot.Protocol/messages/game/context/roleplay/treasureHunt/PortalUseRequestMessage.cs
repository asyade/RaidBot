


















// Generated on 06/26/2015 11:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PortalUseRequestMessage : NetworkMessage
{

public const uint Id = 6492;
public override uint MessageId
{
    get { return Id; }
}

public uint portalId;
        

public PortalUseRequestMessage()
{
}

public PortalUseRequestMessage(uint portalId)
        {
            this.portalId = portalId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(portalId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

portalId = reader.ReadVaruhint();
            if (portalId < 0)
                throw new Exception("Forbidden value on portalId = " + portalId + ", it doesn't respect the following condition : portalId < 0");
            

}


}


}