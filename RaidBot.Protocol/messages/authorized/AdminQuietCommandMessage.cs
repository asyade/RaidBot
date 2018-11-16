


















// Generated on 06/26/2015 11:40:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AdminQuietCommandMessage : AdminCommandMessage
{

public const uint Id = 5662;
public override uint MessageId
{
    get { return Id; }
}



public AdminQuietCommandMessage()
{
}

public AdminQuietCommandMessage(string content)
         : base(content)
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