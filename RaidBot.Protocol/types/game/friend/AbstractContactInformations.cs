


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AbstractContactInformations
{

public const short Id = 380;
public virtual short TypeId
{
    get { return Id; }
}

public int accountId;
        public string accountName;
        

public AbstractContactInformations()
{
}

public AbstractContactInformations(int accountId, string accountName)
        {
            this.accountId = accountId;
            this.accountName = accountName;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteUTF(accountName);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

accountId = reader.ReadInt();
            if (accountId < 0)
                throw new Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            accountName = reader.ReadUTF();
            

}


}


}