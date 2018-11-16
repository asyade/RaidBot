


















// Generated on 06/26/2015 11:41:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ReloginTokenStatusMessage : NetworkMessage
{

public const uint Id = 6539;
public override uint MessageId
{
    get { return Id; }
}

public bool validToken;
        public string token;
        

public ReloginTokenStatusMessage()
{
}

public ReloginTokenStatusMessage(bool validToken, string token)
        {
            this.validToken = validToken;
            this.token = token;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(validToken);
            writer.WriteUTF(token);
            

}

public override void Deserialize(ICustomDataReader reader)
{

validToken = reader.ReadBoolean();
            token = reader.ReadUTF();
            

}


}


}