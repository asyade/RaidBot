


















// Generated on 06/26/2015 11:42:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class MapObstacle
{

public const short Id = 200;
public virtual short TypeId
{
    get { return Id; }
}

public ushort obstacleCellId;
        public sbyte state;
        

public MapObstacle()
{
}

public MapObstacle(ushort obstacleCellId, sbyte state)
        {
            this.obstacleCellId = obstacleCellId;
            this.state = state;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteVaruhshort(obstacleCellId);
            writer.WriteSByte(state);
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

obstacleCellId = reader.ReadVaruhshort();
            if (obstacleCellId < 0 || obstacleCellId > 559)
                throw new Exception("Forbidden value on obstacleCellId = " + obstacleCellId + ", it doesn't respect the following condition : obstacleCellId < 0 || obstacleCellId > 559");
            state = reader.ReadSByte();
            if (state < 0)
                throw new Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
            

}


}


}