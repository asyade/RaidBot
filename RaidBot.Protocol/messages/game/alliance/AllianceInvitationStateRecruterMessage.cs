


















// Generated on 06/26/2015 11:41:05
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AllianceInvitationStateRecruterMessage : NetworkMessage
{

public const uint Id = 6396;
public override uint MessageId
{
    get { return Id; }
}

public string recrutedName;
        public sbyte invitationState;
        

public AllianceInvitationStateRecruterMessage()
{
}

public AllianceInvitationStateRecruterMessage(string recrutedName, sbyte invitationState)
        {
            this.recrutedName = recrutedName;
            this.invitationState = invitationState;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(recrutedName);
            writer.WriteSByte(invitationState);
            

}

public override void Deserialize(ICustomDataReader reader)
{

recrutedName = reader.ReadUTF();
            invitationState = reader.ReadSByte();
            if (invitationState < 0)
                throw new Exception("Forbidden value on invitationState = " + invitationState + ", it doesn't respect the following condition : invitationState < 0");
            

}


}


}