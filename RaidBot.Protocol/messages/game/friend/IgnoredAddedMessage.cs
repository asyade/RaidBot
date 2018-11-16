


















// Generated on 06/26/2015 11:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class IgnoredAddedMessage : NetworkMessage
{

public const uint Id = 5678;
public override uint MessageId
{
    get { return Id; }
}

public Types.IgnoredInformations ignoreAdded;
        public bool session;
        

public IgnoredAddedMessage()
{
}

public IgnoredAddedMessage(Types.IgnoredInformations ignoreAdded, bool session)
        {
            this.ignoreAdded = ignoreAdded;
            this.session = session;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteShort(ignoreAdded.TypeId);
            ignoreAdded.Serialize(writer);
            writer.WriteBoolean(session);
            

}

public override void Deserialize(ICustomDataReader reader)
{

ignoreAdded = Types.ProtocolTypeManager.GetInstance<Types.IgnoredInformations>(reader.ReadShort());
            ignoreAdded.Deserialize(reader);
            session = reader.ReadBoolean();
            

}


}


}