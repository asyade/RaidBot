


















// Generated on 06/26/2015 11:41:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class OrnamentGainedMessage : NetworkMessage
{

public const uint Id = 6368;
public override uint MessageId
{
    get { return Id; }
}

public short ornamentId;
        

public OrnamentGainedMessage()
{
}

public OrnamentGainedMessage(short ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(ornamentId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

ornamentId = reader.ReadShort();
            if (ornamentId < 0)
                throw new Exception("Forbidden value on ornamentId = " + ornamentId + ", it doesn't respect the following condition : ornamentId < 0");
            

}


}


}