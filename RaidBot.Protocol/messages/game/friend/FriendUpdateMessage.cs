


















// Generated on 06/26/2015 11:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class FriendUpdateMessage : NetworkMessage
{

public const uint Id = 5924;
public override uint MessageId
{
    get { return Id; }
}

public Types.FriendInformations friendUpdated;
        

public FriendUpdateMessage()
{
}

public FriendUpdateMessage(Types.FriendInformations friendUpdated)
        {
            this.friendUpdated = friendUpdated;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(friendUpdated.TypeId);
            friendUpdated.Serialize(writer);
            

}

public override void Deserialize(ICustomDataReader reader)
{

friendUpdated = Types.ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadShort());
            friendUpdated.Deserialize(reader);
            

}


}


}