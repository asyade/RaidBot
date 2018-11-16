


















// Generated on 06/26/2015 11:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class InteractiveMapUpdateMessage : NetworkMessage
{

public const uint Id = 5002;
public override uint MessageId
{
    get { return Id; }
}

public Types.InteractiveElement[] interactiveElements;
        

public InteractiveMapUpdateMessage()
{
}

public InteractiveMapUpdateMessage(Types.InteractiveElement[] interactiveElements)
        {
            this.interactiveElements = interactiveElements;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)interactiveElements.Length);
            foreach (var entry in interactiveElements)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            interactiveElements = new Types.InteractiveElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 interactiveElements[i] = Types.ProtocolTypeManager.GetInstance<Types.InteractiveElement>(reader.ReadShort());
                 interactiveElements[i].Deserialize(reader);
            }
            

}


}


}