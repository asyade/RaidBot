


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismFightStateUpdateMessage : NetworkMessage
{

public const uint Id = 6040;
public override uint MessageId
{
    get { return Id; }
}

public sbyte state;
        

public PrismFightStateUpdateMessage()
{
}

public PrismFightStateUpdateMessage(sbyte state)
        {
            this.state = state;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteSByte(state);
            

}

public override void Deserialize(ICustomDataReader reader)
{

state = reader.ReadSByte();
            if (state < 0)
                throw new Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
            

}


}


}