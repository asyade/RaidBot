


















// Generated on 06/26/2015 11:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class FriendDeleteRequestMessage : NetworkMessage
{

public const uint Id = 5603;
public override uint MessageId
{
    get { return Id; }
}

public int accountId;
        

public FriendDeleteRequestMessage()
{
}

public FriendDeleteRequestMessage(int accountId)
        {
            this.accountId = accountId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(accountId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            

}


}


}