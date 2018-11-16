


















// Generated on 06/26/2015 11:41:58
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class KrosmasterAuthTokenMessage : NetworkMessage
{

public const uint Id = 6351;
public override uint MessageId
{
    get { return Id; }
}

public string token;
        

public KrosmasterAuthTokenMessage()
{
}

public KrosmasterAuthTokenMessage(string token)
        {
            this.token = token;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(token);
            

}

public override void Deserialize(ICustomDataReader reader)
{

token = reader.ReadUTF();
            

}


}


}