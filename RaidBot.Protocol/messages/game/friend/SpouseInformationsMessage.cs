


















// Generated on 06/26/2015 11:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SpouseInformationsMessage : NetworkMessage
{

public const uint Id = 6356;
public override uint MessageId
{
    get { return Id; }
}

public Types.FriendSpouseInformations spouse;
        

public SpouseInformationsMessage()
{
}

public SpouseInformationsMessage(Types.FriendSpouseInformations spouse)
        {
            this.spouse = spouse;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(spouse.TypeId);
            spouse.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

spouse = Types.ProtocolTypeManager.GetInstance<Types.FriendSpouseInformations>(reader.ReadShort());
            spouse.Deserialize(reader);
            

}


}


}