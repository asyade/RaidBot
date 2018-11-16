


















// Generated on 06/26/2015 11:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class FriendDeleteResultMessage : NetworkMessage
{

public const uint Id = 5601;
public override uint MessageId
{
    get { return Id; }
}

public bool success;
        public string name;
        

public FriendDeleteResultMessage()
{
}

public FriendDeleteResultMessage(bool success, string name)
        {
            this.success = success;
            this.name = name;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(success);
            writer.WriteUTF(name);
            

}

public override void Deserialize(ICustomDataReader reader)
{

success = reader.ReadBoolean();
            name = reader.ReadUTF();
            

}


}


}