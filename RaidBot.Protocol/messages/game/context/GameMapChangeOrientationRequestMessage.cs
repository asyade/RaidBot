


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameMapChangeOrientationRequestMessage : NetworkMessage
{

public const uint Id = 945;
public override uint MessageId
{
    get { return Id; }
}

public sbyte direction;
        

public GameMapChangeOrientationRequestMessage()
{
}

public GameMapChangeOrientationRequestMessage(sbyte direction)
        {
            this.direction = direction;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(direction);
            

}

public override void Deserialize(ICustomDataReader reader)
{

direction = reader.ReadSByte();
            if (direction < 0)
                throw new Exception("Forbidden value on direction = " + direction + ", it doesn't respect the following condition : direction < 0");
            

}


}


}