


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ClientKeyMessage : NetworkMessage
{

public const uint Id = 5607;
public override uint MessageId
{
    get { return Id; }
}

public string key;
        

public ClientKeyMessage()
{
}

public ClientKeyMessage(string key)
        {
            this.key = key;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(key);
            

}

public override void Deserialize(ICustomDataReader reader)
{

key = reader.ReadUTF();
            

}


}


}