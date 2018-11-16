


















// Generated on 06/26/2015 11:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectGroundRemovedMessage : NetworkMessage
{

public const uint Id = 3014;
public override uint MessageId
{
    get { return Id; }
}

public ushort cell;
        

public ObjectGroundRemovedMessage()
{
}

public ObjectGroundRemovedMessage(ushort cell)
        {
            this.cell = cell;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(cell);
            

}

public override void Deserialize(ICustomDataReader reader)
{

cell = reader.ReadVaruhshort();
            if (cell < 0 || cell > 559)
                throw new Exception("Forbidden value on cell = " + cell + ", it doesn't respect the following condition : cell < 0 || cell > 559");
            

}


}


}