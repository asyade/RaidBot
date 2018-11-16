


















// Generated on 06/26/2015 11:41:09
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CharacterSelectedForceMessage : NetworkMessage
{

public const uint Id = 6068;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        

public CharacterSelectedForceMessage()
{
}

public CharacterSelectedForceMessage(int id)
        {
            this.id = id;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteInt(id);
            

}

public override void Deserialize(ICustomDataReader reader)
{

id = reader.ReadInt();
            if (id < 1 || id > 2147483647)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 1 || id > 2147483647");
            

}


}


}