


















// Generated on 06/26/2015 11:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using RaidBot.Protocol.Types;
using RaidBot.Common.IO;

namespace RaidBot.Protocol.Messages
{

public class ExchangeLeaveMessage : LeaveDialogMessage
{

public const uint Id = 5628;
public override uint MessageId
{
    get { return Id; }
}

public bool success;
        

public ExchangeLeaveMessage()
{
}

public ExchangeLeaveMessage(sbyte dialogType, bool success)
         : base(dialogType)
        {
            this.success = success;
        }
        

public override void Serialize(ICustomDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(success);
            

}

public override void Deserialize(ICustomDataReader reader)
{

base.Deserialize(reader);
            success = reader.ReadBoolean();
            

}


}


}