


















// Generated on 06/26/2015 11:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ObjectUseOnCellMessage : ObjectUseMessage
{

public const uint Id = 3013;
public override uint MessageId
{
    get { return Id; }
}

public ushort cells;
        

public ObjectUseOnCellMessage()
{
}

public ObjectUseOnCellMessage(uint objectUID, ushort cells)
         : base(objectUID)
        {
            this.cells = cells;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVaruhshort(cells);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            cells = reader.ReadVaruhshort();
            if (cells < 0 || cells > 559)
                throw new Exception("Forbidden value on cells = " + cells + ", it doesn't respect the following condition : cells < 0 || cells > 559");
            

}


}


}