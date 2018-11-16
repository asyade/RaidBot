


















// Generated on 06/26/2015 11:41:15
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameFightOptionToggleMessage : NetworkMessage
{

public const uint Id = 707;
public override uint MessageId
{
    get { return Id; }
}

public sbyte option;
        

public GameFightOptionToggleMessage()
{
}

public GameFightOptionToggleMessage(sbyte option)
        {
            this.option = option;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(option);
            

}

public override void Deserialize(ICustomDataReader reader)
{

option = reader.ReadSByte();
            if (option < 0)
                throw new Exception("Forbidden value on option = " + option + ", it doesn't respect the following condition : option < 0");
            

}


}


}