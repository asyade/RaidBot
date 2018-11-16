


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameMapChangeOrientationMessage : NetworkMessage
{

public const uint Id = 946;
public override uint MessageId
{
    get { return Id; }
}

public Types.ActorOrientation orientation;
        

public GameMapChangeOrientationMessage()
{
}

public GameMapChangeOrientationMessage(Types.ActorOrientation orientation)
        {
            this.orientation = orientation;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

orientation.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

orientation = new Types.ActorOrientation();
            orientation.Deserialize(reader);
            

}


}


}