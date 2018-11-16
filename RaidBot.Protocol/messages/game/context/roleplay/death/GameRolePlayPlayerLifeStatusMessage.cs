


















// Generated on 06/26/2015 11:41:22
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class GameRolePlayPlayerLifeStatusMessage : NetworkMessage
{

public const uint Id = 5996;
public override uint MessageId
{
    get { return Id; }
}

public sbyte state;
        

public GameRolePlayPlayerLifeStatusMessage()
{
}

public GameRolePlayPlayerLifeStatusMessage(sbyte state)
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