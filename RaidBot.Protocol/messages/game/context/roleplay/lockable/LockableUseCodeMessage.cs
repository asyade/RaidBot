


















// Generated on 06/26/2015 11:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class LockableUseCodeMessage : NetworkMessage
{

public const uint Id = 5667;
public override uint MessageId
{
    get { return Id; }
}

public string code;
        

public LockableUseCodeMessage()
{
}

public LockableUseCodeMessage(string code)
        {
            this.code = code;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(code);
            

}

public override void Deserialize(ICustomDataReader reader)
{

code = reader.ReadUTF();
            

}


}


}