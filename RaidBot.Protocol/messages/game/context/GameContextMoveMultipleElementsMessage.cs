


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameContextMoveMultipleElementsMessage : NetworkMessage
{

public const uint Id = 254;
public override uint MessageId
{
    get { return Id; }
}

public Types.EntityMovementInformations[] movements;
        

public GameContextMoveMultipleElementsMessage()
{
}

public GameContextMoveMultipleElementsMessage(Types.EntityMovementInformations[] movements)
        {
            this.movements = movements;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)movements.Length);
            foreach (var entry in movements)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            movements = new Types.EntityMovementInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 movements[i] = new Types.EntityMovementInformations();
                 movements[i].Deserialize(reader);
            }
            

}


}


}