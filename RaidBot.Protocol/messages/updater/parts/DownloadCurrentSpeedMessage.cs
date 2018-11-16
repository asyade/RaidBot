


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class DownloadCurrentSpeedMessage : NetworkMessage
{

public const uint Id = 1511;
public override uint MessageId
{
    get { return Id; }
}

public sbyte downloadSpeed;
        

public DownloadCurrentSpeedMessage()
{
}

public DownloadCurrentSpeedMessage(sbyte downloadSpeed)
        {
            this.downloadSpeed = downloadSpeed;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(downloadSpeed);
            

}

public override void Deserialize(ICustomDataReader reader)
{

downloadSpeed = reader.ReadSByte();
            if (downloadSpeed < 1 || downloadSpeed > 10)
                throw new Exception("Forbidden value on downloadSpeed = " + downloadSpeed + ", it doesn't respect the following condition : downloadSpeed < 1 || downloadSpeed > 10");
            

}


}


}