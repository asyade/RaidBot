


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class IdentifiedEntityDispositionInformations : EntityDispositionInformations
{

public const short Id = 107;
public override short TypeId
{
    get { return Id; }
}

public int id;
        

public IdentifiedEntityDispositionInformations()
{
}

public IdentifiedEntityDispositionInformations(short cellId, sbyte direction, int id)
         : base(cellId, direction)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(id);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            id = reader.ReadInt();
            

}


}


}