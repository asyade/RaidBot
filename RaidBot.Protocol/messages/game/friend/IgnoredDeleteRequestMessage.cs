


















// Generated on 06/26/2015 11:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IgnoredDeleteRequestMessage : NetworkMessage
{

public const uint Id = 5680;
public override uint MessageId
{
    get { return Id; }
}

public int accountId;
        public bool session;
        

public IgnoredDeleteRequestMessage()
{
}

public IgnoredDeleteRequestMessage(int accountId, bool session)
        {
            this.accountId = accountId;
            this.session = session;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteBoolean(session);
            

}

public override void Deserialize(ICustomDataReader reader)
{

accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            session = reader.ReadBoolean();
            

}


}


}