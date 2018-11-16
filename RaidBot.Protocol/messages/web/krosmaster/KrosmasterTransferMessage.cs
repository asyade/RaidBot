


















// Generated on 06/26/2015 11:41:59
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class KrosmasterTransferMessage : NetworkMessage
{

public const uint Id = 6348;
public override uint MessageId
{
    get { return Id; }
}

public string uid;
        public sbyte failure;
        

public KrosmasterTransferMessage()
{
}

public KrosmasterTransferMessage(string uid, sbyte failure)
        {
            this.uid = uid;
            this.failure = failure;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteUTF(uid);
            writer.WriteSByte(failure);
            

}

public override void Deserialize(ICustomDataReader reader)
{

uid = reader.ReadUTF();
            failure = reader.ReadSByte();
            if (failure < 0)
                throw new Exception("Forbidden value on failure = " + failure + ", it doesn't respect the following condition : failure < 0");
            

}


}


}