


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class KrosmasterPlayingStatusMessage : NetworkMessage
{

public const uint Id = 6347;
public override uint MessageId
{
    get { return Id; }
}

public bool playing;
        

public KrosmasterPlayingStatusMessage()
{
}

public KrosmasterPlayingStatusMessage(bool playing)
        {
            this.playing = playing;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(playing);
            

}

public override void Deserialize(ICustomDataReader reader)
{

playing = reader.ReadBoolean();
            

}


}


}