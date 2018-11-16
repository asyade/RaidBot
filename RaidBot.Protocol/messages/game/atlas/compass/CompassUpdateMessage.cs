


















// Generated on 06/26/2015 11:41:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CompassUpdateMessage : NetworkMessage
{

public const uint Id = 5591;
public override uint MessageId
{
    get { return Id; }
}

public sbyte type;
        public Types.MapCoordinates coords;
        

public CompassUpdateMessage()
{
}

public CompassUpdateMessage(sbyte type, Types.MapCoordinates coords)
        {
            this.type = type;
            this.coords = coords;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(type);
            writer.WriteShort(coords.TypeId);
            coords.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            coords = Types.ProtocolTypeManager.GetInstance<Types.MapCoordinates>(reader.ReadShort());
            coords.Deserialize(reader);
            

}


}


}