


















// Generated on 06/26/2015 11:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class FriendJoinRequestMessage : NetworkMessage
{

public const uint Id = 5605;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        

public FriendJoinRequestMessage()
{
}

public FriendJoinRequestMessage(string name)
        {
            this.name = name;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(name);
            

}

public override void Deserialize(ICustomDataReader reader)
{

name = reader.ReadUTF();
            

}


}


}