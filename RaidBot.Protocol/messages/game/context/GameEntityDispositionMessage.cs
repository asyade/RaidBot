


















// Generated on 06/26/2015 11:41:14
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameEntityDispositionMessage : NetworkMessage
{

public const uint Id = 5693;
public override uint MessageId
{
    get { return Id; }
}

public Types.IdentifiedEntityDispositionInformations disposition;
        

public GameEntityDispositionMessage()
{
}

public GameEntityDispositionMessage(Types.IdentifiedEntityDispositionInformations disposition)
        {
            this.disposition = disposition;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

disposition.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

disposition = new Types.IdentifiedEntityDispositionInformations();
            disposition.Deserialize(reader);
            

}


}


}