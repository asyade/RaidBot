


















// Generated on 06/26/2015 11:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IgnoredAddRequestMessage : NetworkMessage
{

public const uint Id = 5673;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public bool session;
        

public IgnoredAddRequestMessage()
{
}

public IgnoredAddRequestMessage(string name, bool session)
        {
            this.name = name;
            this.session = session;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteBoolean(session);
            

}

public override void Deserialize(ICustomDataReader reader)
{

name = reader.ReadUTF();
            session = reader.ReadBoolean();
            

}


}


}