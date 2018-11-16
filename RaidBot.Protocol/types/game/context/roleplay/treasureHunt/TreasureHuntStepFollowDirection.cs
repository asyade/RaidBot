


















// Generated on 06/26/2015 11:42:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class TreasureHuntStepFollowDirection : TreasureHuntStep
{

public const short Id = 468;
public override short TypeId
{
    get { return Id; }
}

public sbyte direction;
        public ushort mapCount;
        

public TreasureHuntStepFollowDirection()
{
}

public TreasureHuntStepFollowDirection(sbyte direction, ushort mapCount)
        {
            this.direction = direction;
            this.mapCount = mapCount;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(direction);
            writer.WriteVaruhshort(mapCount);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            direction = reader.ReadSByte();
            if (direction < 0)
                throw new Exception("Forbidden value on direction = " + direction + ", it doesn't respect the following condition : direction < 0");
            mapCount = reader.ReadVaruhshort();
            if (mapCount < 0)
                throw new Exception("Forbidden value on mapCount = " + mapCount + ", it doesn't respect the following condition : mapCount < 0");
            

}


}


}