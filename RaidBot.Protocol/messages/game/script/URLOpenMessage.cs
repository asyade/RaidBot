


















// Generated on 06/26/2015 11:41:55
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class URLOpenMessage : NetworkMessage
{

public const uint Id = 6266;
public override uint MessageId
{
    get { return Id; }
}

public sbyte urlId;
        

public URLOpenMessage()
{
}

public URLOpenMessage(sbyte urlId)
        {
            this.urlId = urlId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(urlId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

urlId = reader.ReadSByte();
            if (urlId < 0)
                throw new Exception("Forbidden value on urlId = " + urlId + ", it doesn't respect the following condition : urlId < 0");
            

}


}


}