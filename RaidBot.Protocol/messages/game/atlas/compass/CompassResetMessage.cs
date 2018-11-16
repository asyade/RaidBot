


















// Generated on 06/26/2015 11:41:07
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class CompassResetMessage : NetworkMessage
{

public const uint Id = 5584;
public override uint MessageId
{
    get { return Id; }
}

public sbyte type;
        

public CompassResetMessage()
{
}

public CompassResetMessage(sbyte type)
        {
            this.type = type;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(type);
            

}

public override void Deserialize(ICustomDataReader reader)
{

type = reader.ReadSByte();
            if (type < 0)
                throw new Exception("Forbidden value on type = " + type + ", it doesn't respect the following condition : type < 0");
            

}


}


}