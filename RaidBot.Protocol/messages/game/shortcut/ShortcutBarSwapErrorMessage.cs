


















// Generated on 06/26/2015 11:41:56
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ShortcutBarSwapErrorMessage : NetworkMessage
{

public const uint Id = 6226;
public override uint MessageId
{
    get { return Id; }
}

public sbyte error;
        

public ShortcutBarSwapErrorMessage()
{
}

public ShortcutBarSwapErrorMessage(sbyte error)
        {
            this.error = error;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(error);
            

}

public override void Deserialize(ICustomDataReader reader)
{

error = reader.ReadSByte();
            if (error < 0)
                throw new Exception("Forbidden value on error = " + error + ", it doesn't respect the following condition : error < 0");
            

}


}


}