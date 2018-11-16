


















// Generated on 06/26/2015 11:41:57
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class OrnamentSelectedMessage : NetworkMessage
{

public const uint Id = 6369;
public override uint MessageId
{
    get { return Id; }
}

public ushort ornamentId;
        

public OrnamentSelectedMessage()
{
}

public OrnamentSelectedMessage(ushort ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(ornamentId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

ornamentId = reader.ReadVaruhshort();
            if (ornamentId < 0)
                throw new Exception("Forbidden value on ornamentId = " + ornamentId + ", it doesn't respect the following condition : ornamentId < 0");
            

}


}


}