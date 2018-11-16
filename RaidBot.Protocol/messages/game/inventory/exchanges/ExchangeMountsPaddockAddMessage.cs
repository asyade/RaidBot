


















// Generated on 06/26/2015 11:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeMountsPaddockAddMessage : NetworkMessage
{

public const uint Id = 6561;
public override uint MessageId
{
    get { return Id; }
}

public Types.MountClientData[] mountDescription;
        

public ExchangeMountsPaddockAddMessage()
{
}

public ExchangeMountsPaddockAddMessage(Types.MountClientData[] mountDescription)
        {
            this.mountDescription = mountDescription;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)mountDescription.Length);
            foreach (var entry in mountDescription)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            mountDescription = new Types.MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 mountDescription[i] = new Types.MountClientData();
                 mountDescription[i].Deserialize(reader);
            }
            

}


}


}