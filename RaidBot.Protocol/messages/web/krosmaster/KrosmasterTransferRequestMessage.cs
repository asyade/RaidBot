


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class KrosmasterTransferRequestMessage : NetworkMessage
{

public const uint Id = 6349;
public override uint MessageId
{
    get { return Id; }
}

public string uid;
        

public KrosmasterTransferRequestMessage()
{
}

public KrosmasterTransferRequestMessage(string uid)
        {
            this.uid = uid;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(uid);
            

}

public override void Deserialize(ICustomDataReader reader)
{

uid = reader.ReadUTF();
            

}


}


}