


















// Generated on 06/26/2015 11:41:55
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismsListRegisterMessage : NetworkMessage
{

public const uint Id = 6441;
public override uint MessageId
{
    get { return Id; }
}

public sbyte listen;
        

public PrismsListRegisterMessage()
{
}

public PrismsListRegisterMessage(sbyte listen)
        {
            this.listen = listen;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(listen);
            

}

public override void Deserialize(ICustomDataReader reader)
{

listen = reader.ReadSByte();
            if (listen < 0)
                throw new Exception("Forbidden value on listen = " + listen + ", it doesn't respect the following condition : listen < 0");
            

}


}


}