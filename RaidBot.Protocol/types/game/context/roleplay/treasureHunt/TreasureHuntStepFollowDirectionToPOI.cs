


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class TreasureHuntStepFollowDirectionToPOI : TreasureHuntStep
{

public const short Id = 461;
public override short TypeId
{
    get { return Id; }
}

public sbyte direction;
        public ushort poiLabelId;
        

public TreasureHuntStepFollowDirectionToPOI()
{
}

public TreasureHuntStepFollowDirectionToPOI(sbyte direction, ushort poiLabelId)
        {
            this.direction = direction;
            this.poiLabelId = poiLabelId;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(direction);
            writer.WriteVaruhshort(poiLabelId);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            direction = reader.ReadSByte();
            if (direction < 0)
                throw new Exception("Forbidden value on direction = " + direction + ", it doesn't respect the following condition : direction < 0");
            poiLabelId = reader.ReadVaruhshort();
            if (poiLabelId < 0)
                throw new Exception("Forbidden value on poiLabelId = " + poiLabelId + ", it doesn't respect the following condition : poiLabelId < 0");
            

}


}


}