


















// Generated on 06/26/2015 11:40:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IdentificationSuccessWithLoginTokenMessage : IdentificationSuccessMessage
{

public const uint Id = 6209;
public override uint MessageId
{
    get { return Id; }
}

public string loginToken;
        

public IdentificationSuccessWithLoginTokenMessage()
{
}

public IdentificationSuccessWithLoginTokenMessage(bool hasRights, bool wasAlreadyConnected, string login, string nickname, int accountId, sbyte communityId, string secretQuestion, double accountCreation, double subscriptionElapsedDuration, double subscriptionEndDate, string loginToken)
         : base(hasRights, wasAlreadyConnected, login, nickname, accountId, communityId, secretQuestion, accountCreation, subscriptionElapsedDuration, subscriptionEndDate)
        {
            this.loginToken = loginToken;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(loginToken);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            loginToken = reader.ReadUTF();
            

}


}


}