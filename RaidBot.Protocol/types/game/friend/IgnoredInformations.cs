


















// Generated on 06/26/2015 11:42:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class IgnoredInformations : AbstractContactInformations
{

public const short Id = 106;
public override short TypeId
{
    get { return Id; }
}



public IgnoredInformations()
{
}

public IgnoredInformations(int accountId, string accountName)
         : base(accountId, accountName)
        {
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            

}


}


}