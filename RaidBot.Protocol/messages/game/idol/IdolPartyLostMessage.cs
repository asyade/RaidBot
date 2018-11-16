


















// Generated on 06/26/2015 11:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IdolPartyLostMessage : NetworkMessage
{

public const uint Id = 6580;
public override uint MessageId
{
    get { return Id; }
}

public ushort idolId;
        

public IdolPartyLostMessage()
{
}

public IdolPartyLostMessage(ushort idolId)
        {
            this.idolId = idolId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(idolId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

idolId = reader.ReadVaruhshort();
            if (idolId < 0)
                throw new Exception("Forbidden value on idolId = " + idolId + ", it doesn't respect the following condition : idolId < 0");
            

}


}


}