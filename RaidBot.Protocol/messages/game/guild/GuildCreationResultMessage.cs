


















// Generated on 06/26/2015 11:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GuildCreationResultMessage : NetworkMessage
{

public const uint Id = 5554;
public override uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public GuildCreationResultMessage()
{
}

public GuildCreationResultMessage(sbyte result)
        {
            this.result = result;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(result);
            

}

public override void Deserialize(ICustomDataReader reader)
{

result = reader.ReadSByte();
            if (result < 0)
                throw new Exception("Forbidden value on result = " + result + ", it doesn't respect the following condition : result < 0");
            

}


}


}