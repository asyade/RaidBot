


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameContextRemoveMultipleElementsWithEventsMessage : GameContextRemoveMultipleElementsMessage
{

public const uint Id = 6416;
public override uint MessageId
{
    get { return Id; }
}

public sbyte[] elementEventIds;
        

public GameContextRemoveMultipleElementsWithEventsMessage()
{
}

public GameContextRemoveMultipleElementsWithEventsMessage(int[] id, sbyte[] elementEventIds)
         : base(id)
        {
            this.elementEventIds = elementEventIds;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)elementEventIds.Length);
            foreach (var entry in elementEventIds)
            {
                 writer.WriteSByte(entry);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            elementEventIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 elementEventIds[i] = reader.ReadSByte();
            }
            

}


}


}