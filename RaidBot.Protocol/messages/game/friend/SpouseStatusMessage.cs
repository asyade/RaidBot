


















// Generated on 06/26/2015 11:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class SpouseStatusMessage : NetworkMessage
{

public const uint Id = 6265;
public override uint MessageId
{
    get { return Id; }
}

public bool hasSpouse;
        

public SpouseStatusMessage()
{
}

public SpouseStatusMessage(bool hasSpouse)
        {
            this.hasSpouse = hasSpouse;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(hasSpouse);
            

}

public override void Deserialize(ICustomDataReader reader)
{

hasSpouse = reader.ReadBoolean();
            

}


}


}