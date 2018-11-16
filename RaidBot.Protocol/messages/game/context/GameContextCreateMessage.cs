


















// Generated on 06/26/2015 11:41:13
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameContextCreateMessage : NetworkMessage
{

public const uint Id = 200;
public override uint MessageId
{
    get { return Id; }
}

public sbyte context;
        

public GameContextCreateMessage()
{
}

public GameContextCreateMessage(sbyte context)
        {
            this.context = context;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(context);
            

}

public override void Deserialize(ICustomDataReader reader)
{

context = reader.ReadSByte();
            if (context < 0)
                throw new Exception("Forbidden value on context = " + context + ", it doesn't respect the following condition : context < 0");
            

}


}


}