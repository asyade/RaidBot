


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameContextMoveElementMessage : NetworkMessage
{

public const uint Id = 253;
public override uint MessageId
{
    get { return Id; }
}

public Types.EntityMovementInformations movement;
        

public GameContextMoveElementMessage()
{
}

public GameContextMoveElementMessage(Types.EntityMovementInformations movement)
        {
            this.movement = movement;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

movement.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

movement = new Types.EntityMovementInformations();
            movement.Deserialize(reader);
            

}


}


}