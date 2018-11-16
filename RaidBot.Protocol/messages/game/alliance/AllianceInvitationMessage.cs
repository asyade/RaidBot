


















// Generated on 06/26/2015 11:41:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceInvitationMessage : NetworkMessage
{

public const uint Id = 6395;
public override uint MessageId
{
    get { return Id; }
}

public uint targetId;
        

public AllianceInvitationMessage()
{
}

public AllianceInvitationMessage(uint targetId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(targetId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

targetId = reader.ReadVaruhint();
            if (targetId < 0)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < 0");
            

}


}


}