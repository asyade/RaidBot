


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class DownloadPartMessage : NetworkMessage
{

public const uint Id = 1503;
public override uint MessageId
{
    get { return Id; }
}

public string id;
        

public DownloadPartMessage()
{
}

public DownloadPartMessage(string id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(id);
            

}

public override void Deserialize(ICustomDataReader reader)
{

id = reader.ReadUTF();
            

}


}


}