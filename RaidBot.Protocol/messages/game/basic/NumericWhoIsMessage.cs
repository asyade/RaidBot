


















// Generated on 06/26/2015 11:41:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class NumericWhoIsMessage : NetworkMessage
{

public const uint Id = 6297;
public override uint MessageId
{
    get { return Id; }
}

public uint playerId;
        public int accountId;
        

public NumericWhoIsMessage()
{
}

public NumericWhoIsMessage(uint playerId, int accountId)
        {
            this.playerId = playerId;
            this.accountId = accountId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhint(playerId);
            writer.WriteInt(accountId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

playerId = reader.ReadVaruhint();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            

}


}


}