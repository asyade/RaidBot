


















// Generated on 06/26/2015 11:41:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class OrnamentSelectErrorMessage : NetworkMessage
{

public const uint Id = 6370;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public OrnamentSelectErrorMessage()
{
}

public OrnamentSelectErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(reason);
            

}

public override void Deserialize(ICustomDataReader reader)
{

reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            

}


}


}