


















// Generated on 06/26/2015 11:41:54
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class PrismInfoJoinLeaveRequestMessage : NetworkMessage
{

public const uint Id = 5844;
public override uint MessageId
{
    get { return Id; }
}

public bool join;
        

public PrismInfoJoinLeaveRequestMessage()
{
}

public PrismInfoJoinLeaveRequestMessage(bool join)
        {
            this.join = join;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

writer.WriteBoolean(join);
            

}

public override void Deserialize(ICustomDataReader reader)
{

join = reader.ReadBoolean();
            

}


}


}