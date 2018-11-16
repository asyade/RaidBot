


















// Generated on 06/26/2015 11:41:23
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayShowChallengeMessage : NetworkMessage
{

public const uint Id = 301;
public override uint MessageId
{
    get { return Id; }
}

public Types.FightCommonInformations commonsInfos;
        

public GameRolePlayShowChallengeMessage()
{
}

public GameRolePlayShowChallengeMessage(Types.FightCommonInformations commonsInfos)
        {
            this.commonsInfos = commonsInfos;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

commonsInfos.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

commonsInfos = new Types.FightCommonInformations();
            commonsInfos.Deserialize(reader);
            

}


}


}