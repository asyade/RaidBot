


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameEntitiesDispositionMessage : NetworkMessage
{

public const uint Id = 5696;
public override uint MessageId
{
    get { return Id; }
}

public Types.IdentifiedEntityDispositionInformations[] dispositions;
        

public GameEntitiesDispositionMessage()
{
}

public GameEntitiesDispositionMessage(Types.IdentifiedEntityDispositionInformations[] dispositions)
        {
            this.dispositions = dispositions;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUShort((ushort)dispositions.Length);
            foreach (var entry in dispositions)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(ICustomDataReader reader)
{

var limit = reader.ReadUShort();
            dispositions = new Types.IdentifiedEntityDispositionInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 dispositions[i] = new Types.IdentifiedEntityDispositionInformations();
                 dispositions[i].Deserialize(reader);
            }
            

}


}


}