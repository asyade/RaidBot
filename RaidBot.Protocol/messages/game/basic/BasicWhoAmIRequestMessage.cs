


















// Generated on 06/26/2015 11:41:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class BasicWhoAmIRequestMessage : NetworkMessage
{

public const uint Id = 5664;
public override uint MessageId
{
    get { return Id; }
}

public bool verbose;
        

public BasicWhoAmIRequestMessage()
{
}

public BasicWhoAmIRequestMessage(bool verbose)
        {
            this.verbose = verbose;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(verbose);
            

}

public override void Deserialize(ICustomDataReader reader)
{

verbose = reader.ReadBoolean();
            

}


}


}