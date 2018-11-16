


















// Generated on 06/26/2015 11:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class LockableChangeCodeMessage : NetworkMessage
{

public const uint Id = 5666;
public override uint MessageId
{
    get { return Id; }
}

public string code;
        

public LockableChangeCodeMessage()
{
}

public LockableChangeCodeMessage(string code)
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