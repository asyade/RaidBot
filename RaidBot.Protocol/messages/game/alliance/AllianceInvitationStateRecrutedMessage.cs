


















// Generated on 06/26/2015 11:41:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceInvitationStateRecrutedMessage : NetworkMessage
{

public const uint Id = 6392;
public override uint MessageId
{
    get { return Id; }
}

public sbyte invitationState;
        

public AllianceInvitationStateRecrutedMessage()
{
}

public AllianceInvitationStateRecrutedMessage(sbyte invitationState)
        {
            this.invitationState = invitationState;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(invitationState);
            

}

public override void Deserialize(ICustomDataReader reader)
{

invitationState = reader.ReadSByte();
            if (invitationState < 0)
                throw new Exception("Forbidden value on invitationState = " + invitationState + ", it doesn't respect the following condition : invitationState < 0");
            

}


}


}