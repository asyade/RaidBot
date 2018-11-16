


















// Generated on 06/26/2015 11:41:55
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CinematicMessage : NetworkMessage
{

public const uint Id = 6053;
public override uint MessageId
{
    get { return Id; }
}

public ushort cinematicId;
        

public CinematicMessage()
{
}

public CinematicMessage(ushort cinematicId)
        {
            this.cinematicId = cinematicId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(cinematicId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

cinematicId = reader.ReadVaruhshort();
            if (cinematicId < 0)
                throw new Exception("Forbidden value on cinematicId = " + cinematicId + ", it doesn't respect the following condition : cinematicId < 0");
            

}


}


}