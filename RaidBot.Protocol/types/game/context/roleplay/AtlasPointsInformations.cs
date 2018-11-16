


















// Generated on 06/26/2015 11:42:04
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Types
{

public class AtlasPointsInformations
{

public const short Id = 175;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte type;
        public Types.MapCoordinatesExtended[] coords;
        

public AtlasPointsInformations()
{
}

public AtlasPointsInformations(sbyte type, Types.MapCoordinatesExtended[] coords)
        {
            this.type = type;
            this.coords = coords;
        }
        

public virtual void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(type);
            writer.WriteUShort((ushort)coords.Length);
            foreach (var entry in coords)
            {
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(ICustomDataReader reader)
{

type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            var limit = reader.ReadUShort();
            coords = new Types.MapCoordinatesExtended[limit];
            for (int i = 0; i < limit; i++)
            {
                 coords[i] = new Types.MapCoordinatesExtended();
                 coords[i].Deserialize(reader);
            }
            

}


}


}