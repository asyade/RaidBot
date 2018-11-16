


















// Generated on 06/26/2015 11:41:08
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class BasicWhoIsNoMatchMessage : NetworkMessage
{

public const uint Id = 179;
public override uint MessageId
{
    get { return Id; }
}

public string search;
        

public BasicWhoIsNoMatchMessage()
{
}

public BasicWhoIsNoMatchMessage(string search)
        {
            this.search = search;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(search);
            

}

public override void Deserialize(ICustomDataReader reader)
{

search = reader.ReadUTF();
            

}


}


}