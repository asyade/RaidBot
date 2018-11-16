


















// Generated on 06/26/2015 11:40:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class AcquaintanceSearchMessage : NetworkMessage
{

public const uint Id = 6144;
public override uint MessageId
{
    get { return Id; }
}

public string nickname;
        

public AcquaintanceSearchMessage()
{
}

public AcquaintanceSearchMessage(string nickname)
        {
            this.nickname = nickname;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(nickname);
            

}

public override void Deserialize(ICustomDataReader reader)
{

nickname = reader.ReadUTF();
            

}


}


}