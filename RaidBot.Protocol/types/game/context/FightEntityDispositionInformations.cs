


















// Generated on 06/26/2015 11:42:01
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class FightEntityDispositionInformations : EntityDispositionInformations
{

public const short Id = 217;
public override short TypeId
{
    get { return Id; }
}

public int carryingCharacterId;
        

public FightEntityDispositionInformations()
{
}

public FightEntityDispositionInformations(short cellId, sbyte direction, int carryingCharacterId)
         : base(cellId, direction)
        {
            this.carryingCharacterId = carryingCharacterId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(carryingCharacterId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            carryingCharacterId = reader.ReadInt();
            

}


}


}